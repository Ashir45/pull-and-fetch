/* ---------- BODY ---------- */
body {
  margin: 0;
  font-family: 'Arial', sans-serif;
  background: linear-gradient(120deg, #0f2027, #203a43, #2c5364);
  color: white;
  text-align: center;
}

/* ---------- HEADER ---------- */
header {
  padding: 80px 20px;
  background: rgba(0,0,0,0.2);
  backdrop-filter: blur(5px);
}

header h1 {
  font-size: 48px;
  margin-bottom: 10px;
}

header p {
  font-size: 20px;
  opacity: 0.8;
  margin-bottom: 30px;
}

/* ---------- BUTTON ---------- */
button {
  padding: 12px 30px;
  font-size: 16px;
  font-weight: bold;
  color: black;
  background: gold;
  border: none;
  border-radius: 25px;
  cursor: pointer;
  transition: all 0.3s ease;
}

button:hover {
  background: orange;
  transform: scale(1.1);
}

/* ---------- CARD / SECTION ---------- */
.card {
  background: rgba(255, 255, 255, 0.1);
  margin: 40px auto;
  padding: 30px;
  width: 80%;
  max-width: 500px;
  border-radius: 15px;
  box-shadow: 0 8px 20px rgba(0,0,0,0.3);
}

.card h2 {
  margin-bottom: 15px;
}

.card p {
  line-height: 1.6;
  opacity: 0.9;
}

/* ---------- FOOTER ---------- */
footer {
  margin-top: 60px;
  padding: 20px;
  background: rgba(0,0,0,0.4);
  font-size: 14px;
  opacity: 0.9;
}

/* ---------- RESPONSIVE ---------- */
@media screen and (max-width: 600px) {
  header h1 {
    font-size: 36px;
  }

  header p {
    font-size: 16px;
  }

  .card {
    width: 90%;
    padding: 20px;
  }
}
