function stringIsEmptyOrWhitespace(value) {
    return typeof value == 'string' && !value.trim() || typeof value == 'undefined' || value === null;
    //True when: isEmpty(undefined);  isEmpty(null);  isEmpty('');
    //false when: isEmpty('foo');  isEmpty(1);  isEmpty(0); 
}

function roundNumber(num, scale) {
    if (!("" + num).includes("e")) {
        return +(Math.round(num + "e+" + scale) + "e-" + scale);
    } else {
        var arr = ("" + num).split("e");
        var sig = ""
        if (+arr[1] + scale > 0) {
            sig = "+";
        }
        return +(Math.round(+arr[0] + "e" + sig + (+arr[1] + scale)) + "e-" + scale);
    }
}

function ToBool(value) {
    var typ = typeof value;
    if (typ == 'string') {
        if (value == 'true' || value == 'True' || value == 'TRUE') return new Boolean(true);
        return new Boolean(false);
    }
    if (typ == 'number') {
        if (value > 0) return new Boolean(true);
        return new Boolean(false);
    }
    if (typ == 'boolean') {
        return value;
    }
    if (typ == 'undefined') {
        return new Boolean(false);
    }
}


function stringisIMAGE(str) {
    str = str.toLowerCase();
    if (
        str.endsWith(".jpg") || str.endsWith(".jpeg") || str.endsWith(".bmp") || str.endsWith(".jfif") || str.endsWith(".png") || str.endsWith(".gif") || str.endsWith(".apng") || str.endsWith(".ico") || str.endsWith(".cur") || str.endsWith(".pjpeg") || str.endsWith(".pjp") || str.endsWith(".svg") || str.endsWith(".tif") || str.endsWith(".tiff") || str.endsWith(".webp")
     ) {
        //is an image
        return true;
    }
    return false;
}

var root = location.protocol + "//" + location.host;
var pathname = location.pathname;