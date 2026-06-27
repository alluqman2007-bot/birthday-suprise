@import url('https://fonts.googleapis.com/css2?family=Poppins:wght@300;400;600&family=Playfair+Display:ital,wght@1,600&display=swap');

body {
    margin: 0;
    padding: 0;
    background-color: #f7f1f9; /* Pastel lavender estetik */
    color: #4a4a4a;
    font-family: 'Poppins', sans-serif;
    overflow-x: hidden;
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
}

/* 1. Muka Hadapan (Gerbang Bunga) */
#start-screen {
    position: absolute;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    background-color: rgba(247, 241, 249, 0.98); 
    z-index: 10;
    cursor: pointer;
    transition: opacity 1s ease-out, transform 1s ease-out;
}

#flower-gate {
    position: relative;
    width: 300px;
    height: 300px;
    margin-bottom: 20px;
}

.flower-part {
    position: absolute;
    top: 0;
    width: 150px;
    height: 100%;
    background-size: cover;
    background-repeat: no-repeat;
    transition: transform 1.2s ease-in-out;
    border-radius: 10px;
}

/* Gambar bunga wisteria diletakkan menggunakan CSS */
.flower-left {
    left: 0;
    background-image: url('https://w0.peakpx.com/wallpaper/705/850/HD-wallpaper-wisteria-tree-in-bloom-purple-blossom-purple-flowers-beautiful-garden-wisteria-gate-springtime-blossoming-wisteria-purple-tree-gate-of-flowers.jpg');
    background-position: left;
    border-top-right-radius: 0;
    border-bottom-right-radius: 0;
}

.flower-right {
    right: 0;
    background-image: url('https://w0.peakpx.com/wallpaper/705/850/HD-wallpaper-wisteria-tree-in-bloom-purple-blossom-purple-flowers-beautiful-garden-wisteria-gate-springtime-blossoming-wisteria-purple-tree-gate-of-flowers.jpg');
    background-position: right;
    border-top-left-radius: 0;
    border-bottom-left-radius: 0;
}

#start-screen.open .flower-left {
    transform: translateX(-150px) rotateY(-90deg);
}

#start-screen.open .flower-right {
    transform: translateX(150px) rotateY(90deg);
}

.click-text {
    font-size: 16px;
    color: #7b4f9e; 
    letter-spacing: 2px;
    animation: fadeInOut 2s infinite;
}

@keyframes fadeInOut {
    0%, 100% { opacity: 0.5; }
    50% { opacity: 1; }
}

/* 2. Kandungan Utama */
#main-content {
    opacity: 0;
    transform: scale(0.9);
    transition: opacity 1.5s ease-in, transform 1.5s ease-in;
    padding: 50px 20px;
    max-width: 600px;
    margin: 0 auto;
    text-align: center;
    z-index: 1;
    pointer-events: none; 
}

#main-content.visible {
    opacity: 1;
    transform: scale(1);
    pointer-events: auto;
}

section {
    margin-bottom: 80px;
}

.aesthetic-font {
    font-family: 'Playfair Display', serif;
    color: #7b4f9e; 
}

/* Countdown */
.countdown-title {
    font-size: 1.2rem;
    letter-spacing: 3px;
    text-transform: uppercase;
    margin-bottom: 10px;
}

#timer {
    font-size: 2.5rem;
    font-weight: 600;
    color: #e29578; 
    background: white;
    padding: 15px;
    border-radius: 15px;
    box-shadow: 0 4px 15px rgba(0,0,0,0.05);
    display: inline-block;
}

/* Ucapan */
h1 {
    font-size: 2.2rem;
    margin-bottom: 20px;
}

.kata-kata {
    font-size: 1.1rem;
    line-height: 1.8;
    background: white;
    padding: 30px;
    border-radius: 20px;
    box-shadow: 0 4px 15px rgba(0,0,0,0.05);
}

/* 6 Petak (Cards) */
h2 {
    font-size: 1.8rem;
    margin-bottom: 30px;
}

.grid-container {
    display: grid;
    grid-template-columns: repeat(2, 1fr);
    gap: 20px;
}

.card {
    background-color: transparent;
    height: 120px;
    perspective: 1000px;
    cursor: pointer;
}

.card-inner {
    position: relative;
    width: 100%;
    height: 100%;
    text-align: center;
    transition: transform 0.6s;
    transform-style: preserve-3d;
}

.card.flip .card-inner {
    transform: rotateY(180deg);
}

.card-front, .card-back {
    position: absolute;
    width: 100%;
    height: 100%;
    -webkit-backface-visibility: hidden;
    backface-visibility: hidden;
    display: flex;
    align-items: center;
    justify-content: center;
    border-radius: 15px;
    box-shadow: 0 4px 10px rgba(0,0,0,0.05);
    padding: 10px;
    box-sizing: border-box;
}

.card-front {
    background-color: white;
    color: #7b4f9e; 
    font-size: 24px;
}

.card-back {
    background-color: #e29578; 
    color: white;
    transform: rotateY(180deg);
    font-size: 14px;
    font-weight: 600;
}
