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
