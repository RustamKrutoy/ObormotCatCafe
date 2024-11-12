let currentIndex = 0;

function moveSlide(direction) {
    const slides = document.querySelector('.slides');
    const slideCount = document.querySelectorAll('.slide').length;

    currentIndex = (currentIndex + direction + slideCount) % slideCount;
    const offset = -currentIndex * 100;  // Сдвигаем слайд на 100% ширины
    slides.style.transform = `translateX(${offset}%)`;
}

// Инициализация
moveSlide(0);
