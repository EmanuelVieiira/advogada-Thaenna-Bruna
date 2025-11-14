// ===== CARROSSEL =====
document.addEventListener("DOMContentLoaded", function () {
  const myCarousel = document.getElementById("mainCarousel");
  
  if (myCarousel) {
    // Cria a instância do carrossel Bootstrap
    const carousel = new bootstrap.Carousel(myCarousel, {
      interval: 5000, // Muda de slide a cada 5 segundos
      wrap: true, // Volta para o primeiro slide após o último
      touch: true // Suporta touch em mobile
    });

    // Pausar ao passar o mouse
    myCarousel.addEventListener("mouseenter", () => {
      carousel.pause();
    });

    // Retomar quando o mouse sair
    myCarousel.addEventListener("mouseleave", () => {
      carousel.cycle();
    });
  }
});

// ===== HEADER COM SCROLL =====
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

// ===== SCROLL SUAVE PARA ÂNCORAS =====
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

// ===== EFEITO DE CLIQUE NA IMAGEM =====
const img = document.querySelector(".shadow-pop-tr");

if (img) {
  img.addEventListener("click", () => {
    img.classList.remove("shadow-pop-tr");
    void img.offsetWidth; // Força o reflow
    img.classList.add("shadow-pop-tr");
  });
}

// ===== EFEITO HOVER NOS CARDS =====
document.querySelectorAll('.card-body').forEach(cardBody => {
  const bg = cardBody.parentElement.querySelector('.card-bg');

  if (bg) {
    cardBody.addEventListener('mouseenter', () => {
      bg.style.opacity = '0.9';
    });

    cardBody.addEventListener('mouseleave', () => {
      bg.style.opacity = '0';
    });
  }
});