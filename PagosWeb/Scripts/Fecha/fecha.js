function fecha(jsonFecha) {
    var fecha = new Date(parseInt(jsonFecha.substr(6)));
    var month = fecha.getMonth() + 1;
    var day = fecha.getDate();
    var year = fecha.getFullYear();
    var f = day + "/" + month + "/" + year;
    return f;
}
function fecha2(jsonFecha) {
    var fecha = new Date(parseInt(jsonFecha.substr(6)));
    return fecha.format("dd/mm/yyyy");
}
