document.addEventListener('keydown', function (event) {
    console.log('before if: ' + event.key);
    if (event.ctrlKey && event.key === '0') {
        window.location.href = 'http://localhost:5243/Auth?shortcut=ctrl+0';
    }
});