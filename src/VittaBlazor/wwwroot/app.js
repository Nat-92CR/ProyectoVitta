// Función auxiliar para descargar contenidos como archivo desde Blazor.
// Recibe el nombre del archivo y el contenido en texto plano.
window.descargarArchivo = (nombreArchivo, contenido) => {
    const bom = "\uFEFF"; // BOM para que Excel respete tildes en UTF-8.
    const blob = new Blob([bom + contenido], { type: "text/csv;charset=utf-8;" });
    const url = URL.createObjectURL(blob);
    const link = document.createElement("a");
    link.href = url;
    link.download = nombreArchivo;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
    URL.revokeObjectURL(url);
};

// Función auxiliar para descargar el reporte visual en HTML.
// Se abre en cualquier navegador y desde ahí se puede imprimir o guardar como PDF.
window.descargarArchivoHtml = (nombreArchivo, contenido) => {
    const blob = new Blob([contenido], { type: "text/html;charset=utf-8;" });
    const url = URL.createObjectURL(blob);
    const link = document.createElement("a");
    link.href = url;
    link.download = nombreArchivo;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
    URL.revokeObjectURL(url);
};

window.vittaReports = window.vittaReports || {};

window.vittaReports.openHtmlReport = function (htmlContent) {
    const reportWindow = window.open("", "_blank");

    if (!reportWindow) {
        alert("No se pudo abrir la ventana del reporte.");
        return;
    }

    reportWindow.document.open();
    reportWindow.document.write(htmlContent);
    reportWindow.document.close();
};