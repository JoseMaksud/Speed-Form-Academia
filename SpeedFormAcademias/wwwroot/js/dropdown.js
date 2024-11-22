document.addEventListener('DOMContentLoaded', function () {
    document.querySelectorAll('.dropdown > a').forEach(link => {
        link.addEventListener('click', function (event) {
            event.preventDefault(); 
            event.stopPropagation(); 

            const submenu = link.nextElementSibling; 
            const isOpen = submenu.style.display === 'block'; 

            
            document.querySelectorAll('.submenu').forEach(sub => {
                sub.style.display = 'none'; 
                sub.parentElement.classList.remove('active');
            });
            if (!isOpen) {
                submenu.style.display = 'block';
                link.parentElement.classList.add('active'); 
            }
        });
    });

    document.addEventListener('click', function (event) {
        if (!event.target.closest('.navbar')) {
            document.querySelectorAll('.submenu').forEach(sub => {
                sub.style.display = 'none';
                sub.parentElement.classList.remove('active'); 
            });
        }
    });
    document.querySelectorAll('.submenu').forEach(submenu => {
        submenu.addEventListener('click', function (event) {
            event.stopPropagation(); 
        });
    });
});



document.addEventListener('DOMContentLoaded', function () {
    // Alternar o menu hamburguer
    document.querySelector('.menu-toggle').addEventListener('click', function () {
        const navbar = document.querySelector('.navbar');
        navbar.classList.toggle('active');

        // Exibir ou ocultar os itens do submenu mobile com base na visibilidade do menu
        const submenuMobileItems = document.querySelectorAll('.submenuMobile');
        submenuMobileItems.forEach(item => {
            if (navbar.classList.contains('active')) {
                item.style.display = 'block';
            } else {
                item.style.display = 'none';
            }
        });
    });

    // Fechar o menu ao clicar fora
    document.addEventListener('click', function (event) {
        if (!event.target.closest('.navbar') && !event.target.closest('.menu-toggle')) {
            document.querySelector('.navbar').classList.remove('active');
            
            // Esconder os itens do submenu mobile ao fechar o menu
            const submenuMobileItems = document.querySelectorAll('.submenuMobile');
            submenuMobileItems.forEach(item => {
                item.style.display = 'none';
            });
        }
    });
});
