// To parse this data:
//
//   const Convert = require("./file");
//
//   const healthcare = Convert.toHealthcare(json);
//
// These functions will throw an error if the JSON doesn't
// match the expected interface, even if the JSON is valid.

// Converts JSON strings to/from your types
// and asserts the results of JSON.parse at runtime
function toHealthcare(json) {
    return cast(JSON.parse(json), a(r("Healthcare")));
}

function healthcareToJson(value) {
    return JSON.stringify(uncast(value, a(r("Healthcare"))), null, 2);
}

function invalidValue(typ, val, key = '') {
    if (key) {
        throw Error(`Invalid value for key "${key}". Expected type ${JSON.stringify(typ)} but got ${JSON.stringify(val)}`);
    }
    throw Error(`Invalid value ${JSON.stringify(val)} for type ${JSON.stringify(typ)}`,);
}

function jsonToJSProps(typ) {
    if (typ.jsonToJS === undefined) {
        const map = {};
        typ.props.forEach((p) => map[p.json] = { key: p.js, typ: p.typ });
        typ.jsonToJS = map;
    }
    return typ.jsonToJS;
}

function jsToJSONProps(typ) {
    if (typ.jsToJSON === undefined) {
        const map = {};
        typ.props.forEach((p) => map[p.js] = { key: p.json, typ: p.typ });
        typ.jsToJSON = map;
    }
    return typ.jsToJSON;
}

function transform(val, typ, getProps, key = '') {
    function transformPrimitive(typ, val) {
        if (typeof typ === typeof val) return val;
        return invalidValue(typ, val, key);
    }

    function transformUnion(typs, val) {
        // val must validate against one typ in typs
        const l = typs.length;
        for (let i = 0; i < l; i++) {
            const typ = typs[i];
            try {
                return transform(val, typ, getProps);
            } catch (_) { }
        }
        return invalidValue(typs, val);
    }

    function transformEnum(cases, val) {
        if (cases.indexOf(val) !== -1) return val;
        return invalidValue(cases, val);
    }

    function transformArray(typ, val) {
        // val must be an array with no invalid elements
        if (!Array.isArray(val)) return invalidValue("array", val);
        return val.map(el => transform(el, typ, getProps));
    }

    function transformDate(val) {
        if (val === null) {
            return null;
        }
        const d = new Date(val);
        if (isNaN(d.valueOf())) {
            return invalidValue("Date", val);
        }
        return d;
    }

    function transformObject(props, additional, val) {
        if (val === null || typeof val !== "object" || Array.isArray(val)) {
            return invalidValue("object", val);
        }
        const result = {};
        Object.getOwnPropertyNames(props).forEach(key => {
            const prop = props[key];
            const v = Object.prototype.hasOwnProperty.call(val, key) ? val[key] : undefined;
            result[prop.key] = transform(v, prop.typ, getProps, prop.key);
        });
        Object.getOwnPropertyNames(val).forEach(key => {
            if (!Object.prototype.hasOwnProperty.call(props, key)) {
                result[key] = transform(val[key], additional, getProps, key);
            }
        });
        return result;
    }

    if (typ === "any") return val;
    if (typ === null) {
        if (val === null) return val;
        return invalidValue(typ, val);
    }
    if (typ === false) return invalidValue(typ, val);
    while (typeof typ === "object" && typ.ref !== undefined) {
        typ = typeMap[typ.ref];
    }
    if (Array.isArray(typ)) return transformEnum(typ, val);
    if (typeof typ === "object") {
        return typ.hasOwnProperty("unionMembers") ? transformUnion(typ.unionMembers, val)
            : typ.hasOwnProperty("arrayItems") ? transformArray(typ.arrayItems, val)
                : typ.hasOwnProperty("props") ? transformObject(getProps(typ), typ.additional, val)
                    : invalidValue(typ, val);
    }
    // Numbers can be parsed by Date but shouldn't be.
    if (typ === Date && typeof val !== "number") return transformDate(val);
    return transformPrimitive(typ, val);
}

function cast(val, typ) {
    return transform(val, typ, jsonToJSProps);
}

function uncast(val, typ) {
    return transform(val, typ, jsToJSONProps);
}

function a(typ) {
    return { arrayItems: typ };
}

function u(...typs) {
    return { unionMembers: typs };
}

function o(props, additional) {
    return { props, additional };
}

function m(additional) {
    return { props: [], additional };
}

function r(name) {
    return { ref: name };
}

const typeMap = {
    "Healthcare": o([
        { json: "health_center", js: "health_center", typ: "" },
        { json: "health_center_code", js: "health_center_code", typ: "" },
        { json: "address", js: "address", typ: "" },
        { json: "street_name", js: "street_name", typ: "" },
        { json: "sufx", js: "sufx", typ: r("Sufx") },
        { json: "city", js: "city", typ: r("City") },
        { json: "state", js: "state", typ: r("State") },
        { json: "zipcode", js: "zipcode", typ: "" },
        { json: "phone", js: "phone", typ: "" },
        { json: "care_type", js: "care_type", typ: "" },
        { json: "monday_open", js: "monday_open", typ: u(undefined, r("DayOpen")) },
        { json: "monday_close", js: "monday_close", typ: u(undefined, "") },
        { json: "tuesday_open", js: "tuesday_open", typ: u(undefined, r("DayOpen")) },
        { json: "tuesday_close", js: "tuesday_close", typ: u(undefined, "") },
        { json: "wednesday_open", js: "wednesday_open", typ: u(undefined, r("DayOpen")) },
        { json: "wednesday_close", js: "wednesday_close", typ: u(undefined, "") },
        { json: "thursday_open", js: "thursday_open", typ: u(undefined, r("DayOpen")) },
        { json: "thursday_close", js: "thursday_close", typ: u(undefined, "") },
        { json: "friday_open", js: "friday_open", typ: u(undefined, r("DayOpen")) },
        { json: "friday_close", js: "friday_close", typ: u(undefined, "") },
        { json: "neighborhood", js: "neighborhood", typ: "" },
        { json: "latitude", js: "latitude", typ: "" },
        { json: "longitude", js: "longitude", typ: "" },
        { json: "services_provided", js: "services_provided", typ: u(undefined, "") },
        { json: "center_description", js: "center_description", typ: u(undefined, "") },
        { json: "insurance_accepted", js: "insurance_accepted", typ: u(undefined, "") },
        { json: "title_x_services", js: "title_x_services", typ: u(undefined, r("Adult")) },
        { json: "adult", js: "adult", typ: u(undefined, r("Adult")) },
        { json: "pediatrics", js: "pediatrics", typ: u(undefined, r("Adult")) },
        { json: "ob", js: "ob", typ: u(undefined, r("Adult")) },
        { json: "nursing_services", js: "nursing_services", typ: u(undefined, r("Adult")) },
        { json: "lab", js: "lab", typ: u(undefined, r("Adult")) },
        { json: "immunizations", js: "immunizations", typ: u(undefined, r("Adult")) },
        { json: "outreach_enrollment_services", js: "outreach_enrollment_services", typ: u(undefined, r("Adult")) },
        { json: "gyn", js: "gyn", typ: u(undefined, r("Adult")) },
        { json: "sti_testing", js: "sti_testing", typ: u(undefined, r("Adult")) },
        { json: "pharmacy", js: "pharmacy", typ: u(undefined, r("Adult")) },
        { json: "diabetic_education", js: "diabetic_education", typ: u(undefined, r("Adult")) },
        { json: "wic", js: "wic", typ: u(undefined, r("Adult")) },
        { json: "behavioral_health", js: "behavioral_health", typ: u(undefined, r("Adult")) },
        { json: "safe_place", js: "safe_place", typ: u(undefined, r("Adult")) },
        { json: "special_hours_notes", js: "special_hours_notes", typ: u(undefined, "") },
    ], false),
    "Adult": [
        "no",
        "No",
        "Yes",
    ],
    "City": [
        "CINCINNATI",
    ],
    "DayOpen": [
        "10:00 AM",
        "7:00 AM",
        "7:30 AM",
        "7:45 AM",
        "8:00 AM",
        "9:00 AM",
    ],
    "State": [
        "OH",
    ],
    "Sufx": [
        "AV",
        "DR",
        "PL",
        "RD",
        "ST",
    ],
};

module.exports = {
    "healthcareToJson": healthcareToJson,
    "toHealthcare": toHealthcare,
};
