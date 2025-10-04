// carrossel
document.addEventListener("DOMContentLoaded", function () {
  const myCarousel = document.getElementById("mainCarousel");
  const carousel = new bootstrap.Carousel(myCarousel);
  carousel._config.interval = 5000;
  // Pausar ao passar o mouse
  myCarousel.addEventListener("mouseenter", () => {
    carousel.pause();
  });
  // Retomar quando o mouse sair
  myCarousel.addEventListener("mouseleave", () => {
    carousel.cycle();
  });
});
window.addEventListener("scroll", () => {
  const header = document.querySelector("header");
  if (window.scrollY > 100) {
    // Quando rola mais de 100px, fica mais transparente
    header.style.backgroundColor = "rgba(58, 14, 26, 0.95)";
    header.style.backdropFilter = "blur(10px)";
  } else {
    // No topo, volta ao normal
    header.style.backgroundColor = "";
    header.style.backdropFilter = "";
  }
});
document.querySelectorAll('nav a[href^="#"]').forEach((anchor) => {
  anchor.addEventListener("click", function (e) {
    e.preventDefault();
    const target = document.querySelector(this.getAttribute("href"));
    if (target) {
      const headerOffset = 100; // Compensa a altura do header
      const elementPosition = target.getBoundingClientRect().top;
      const offsetPosition =
        elementPosition + window.pageYOffset - headerOffset;

      window.scrollTo({
        top: offsetPosition,
        behavior: "smooth",
      });
    }
  });
});

// Efeito de clique na imagem
const img = document.querySelector(".shadow-pop-tr");

img.addEventListener("click", () => {
  img.classList.remove("shadow-pop-tr"); // remove se já tiver
  void img.offsetWidth; 
  img.classList.add("shadow-pop-tr"); 
});

  document.querySelectorAll('.card-body').forEach(cardBody => {
    const bg = cardBody.parentElement.querySelector('.card-bg');

    cardBody.addEventListener('mouseenter', () => {
      bg.style.opacity = '0.9'; // ou o valor que quiser
    });

    cardBody.addEventListener('mouseleave', () => {
      bg.style.opacity = '0';
    });
  });
