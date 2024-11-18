function addResizeEvent(dotnetRef) {
    window.addEventListener("resize", () => {
        dotnetRef.invokeMethodAsync("OnResize");
    });
}

function getBoundingClientRect(element) {
    return element.getBoundingClientRect();
}
function getBoundingClientRect(button) {
    return button.getBoundingClientRect();
}

// Yukarı çık butonunu seçin
const scrollToTopButton = document.getElementById('scrollToTop');

// Sayfa kaydırıldığında kontrol et
window.addEventListener('scroll', () => {
  if (window.scrollY > 200) {
    scrollToTopButton.classList.add('show');
  } else {
    scrollToTopButton.classList.remove('show');
  }
});

// Tıklama olayını dinleyerek sayfanın başına kaydır
scrollToTopButton.addEventListener('click', (e) => {
  e.preventDefault();
  window.scrollTo({ top: 0, behavior: 'smooth' });
});

