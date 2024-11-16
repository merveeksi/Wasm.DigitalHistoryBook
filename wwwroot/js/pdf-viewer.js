function loadPdf(pdfUrl, dotNetHelper) {
    const pdfjsLib = window['pdfjs-dist/build/pdf'];

    // PDF.js işçi dosyasını belirtiyoruz
    pdfjsLib.GlobalWorkerOptions.workerSrc = 'https://cdnjs.cloudflare.com/ajax/libs/pdf.js/2.16.105/pdf.worker.min.js';

    const loadingTask = pdfjsLib.getDocument(pdfUrl);
    loadingTask.promise.then(function(pdf) {
        const viewer = document.getElementById('pdf-viewer');
        viewer.innerHTML = ''; // Temizle

        console.log("PDF yükleniyor");

        // Toplam sayfa sayısını Blazor'a gönder
        dotNetHelper.invokeMethodAsync('SetTotalPages', pdf.numPages);

        // İlk sayfayı yükle
        loadPage(pdf, 1, viewer);
    }).catch(function(error) {
        console.error("PDF yüklenirken hata oluştu: ", error);
    });
}

function loadPage(pdf, pageNumber, viewer) {
    pdf.getPage(pageNumber).then(function(page) {
        const viewport = page.getViewport({ scale: 1.5 });
        const canvas = document.createElement('canvas');
        const context = canvas.getContext('2d');
        canvas.height = viewport.height;
        canvas.width = viewport.width;

        viewer.appendChild(canvas);

        const renderContext = {
            canvasContext: context,
            viewport: viewport,
        };
        page.render(renderContext);
    });
}

function updatePdfPage(pageNumber) {
    const viewer = document.getElementById('pdf-viewer');
    viewer.innerHTML = ''; // Temizle

    const loadingTask = pdfjsLib.getDocument(pdfUrl);
    loadingTask.promise.then(function(pdf) {
        loadPage(pdf, pageNumber, viewer);
    });
}