// Fungsi untuk buka pintu bunga wisteria
function startSurprise() {
    let startScreen = document.getElementById('start-screen');
    let main = document.getElementById('main-content');

    startScreen.classList.add('open'); // Mula animasi pintu buka
    main.classList.add('visible'); // Kandungan utama mula nampak
    
    // Sembunyikan skrin permulaan sepenuhnya selepas animasi habis
    setTimeout(() => {
        startScreen.style.display = 'none';
        // Buang setting body yang kunci view di tengah supaya boleh scroll
        document.body.style.height = 'auto';
        document.body.style.display = 'block';
    }, 1200); 

    window.scrollTo(0,0);
}

// --- EDIT TARIKH HARI JADI DEKAT SINI ---
// Format: "Bulan Hari, Tahun Jam:Minit:Saat" (Cth: "Aug 15, 2026 00:00:00")
var countDownDate = new Date("Aug 15, 2026 00:00:00").getTime();

var x = setInterval(function() {
    var now = new Date().getTime();
    var distance = countDownDate - now;

    var days = Math.floor(distance / (1000 * 60 * 60 * 24));
    var hours = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
    var minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
    var seconds = Math.floor((distance % (1000 * 60)) / 1000);

    // Jika tarikh dah lepas / tiba masa
    if (distance < 0) {
        clearInterval(x);
        document.getElementById("timer").innerHTML = "HAPPY BIRTHDAY! 🎉";
    } else {
        document.getElementById("timer").innerHTML = days + "d " + hours + "h " + minutes + "m " + seconds + "s ";
    }
}, 1000);
