/* Reset Dasar */
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

/* style.css */
* { margin: 0; padding: 0; box-sizing: border-box; }

body {
    background: #f4f4f4;
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
    font-family: sans-serif;
}

.card {
    background: white;
    padding: 20px;
    border-radius: 20px;
    text-align: center;
    width: 320px;
    box-shadow: 0 10px 30px rgba(0,0,0,0.1);
}

/* KUNCI PERBAIKAN: Slider harus presisi */
.slider-container {
    width: 200px;           /* Ukuran Jendela */
    height: 200px;
    margin: 0 auto 15px;
    overflow: hidden;       /* Potong gambar yang mengintip */
    border-radius: 50%;
    border: 5px solid #3498db;
}

.slider-track {
    display: flex;
    width: 800px;           /* Harus 200px x 4 foto */
    animation: motion 12s infinite cubic-bezier(0.45, 0.05, 0.55, 0.95);
}

.slider-track img {
    width: 200px;           /* Harus SAMA dengan container */
    height: 200px;
    object-fit: cover;      /* Full & Center */
    flex-shrink: 0;         /* Cegah gambar terhimpit */
}

@keyframes motion {
    0%, 20%   { transform: translateX(0); }
    25%, 45%  { transform: translateX(-200px); }
    50%, 70%  { transform: translateX(-400px); }
    75%, 95%  { transform: translateX(-600px); }
    100%      { transform: translateX(-600px); }
}

/* --- TOMBOL --- */
.button-group {
    display: flex;
    flex-direction: column;
    gap: 12px;
}

.btn {
    padding: 12px;
    border-radius: 10px;
    text-decoration: none;
    color: white;
    font-weight: bold;
    font-size: 14px;
    transition: all 0.3s ease;
    border: none;
    cursor: pointer;
}

.btn:active { transform: scale(0.95); }

.ig { background: #e1306c; }
.wa { background: #25d366; }
.gh { background: #333; }
.story-btn { background: #f39c12; }

/* --- OVERLAY CERITA --- */
.overlay {
    display: none; 
    position: fixed; /* Agar melayang di atas semua konten */
    top: 0; left: 0;
    width: 100%; height: 100%;
    background: rgba(0,0,0,0.9);
    z-index: 9999; /* Agar paling depan */
    justify-content: center;
    align-items: center;
    flex-direction: column;
}

.story-content img {
    max-width: 85%;
    max-height: 70vh;
    border-radius: 15px;
    border: 3px solid white;
}

.story-content p { color: white; margin-top: 20px; }
.close-btn {
    position: absolute; top: 20px; right: 30px;
    color: white; font-size: 40px; cursor: pointer;
}
