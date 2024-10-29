function showContent(contentId) {
  const sections = document.querySelectorAll('.content-section');
  sections.forEach(section => {
      if (section.id === contentId) return;
      section.style.transition = 'none';
      section.style.opacity = '0';
      section.style.transform = 'translateX(100%)';
      section.style.display = 'none';
  });

  const circles = document.querySelectorAll('.carrossel-circle');
  circles.forEach(circle => circle.classList.remove('selecionado'));

  const activeSection = document.getElementById(contentId);
  activeSection.style.display = 'flex';
  setTimeout(() => {
      activeSection.style.transition = 'all 0.9s ease';
      activeSection.style.opacity = '1';
      activeSection.style.transform = 'translateX(0)';
  }, 10);

  const activeCircle = document.querySelector(`[data-year="${contentId.split('-')[1]}"]`);
  activeCircle.classList.add('selecionado');

  showImage(contentId.split('-')[1]);
}

function showImage(year) {
  const images = document.querySelectorAll('.imagensAnos img');
  images.forEach(img => {
    img.classList.remove('selecionadoimg');
    if (img.getAttribute('data-year') === year) {
      img.classList.add('selecionadoimg');
    }
  });
}

document.addEventListener('DOMContentLoaded', function() {
  showContent('content-2008');
});
