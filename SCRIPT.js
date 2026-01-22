// Simple Button Click Alert
function showMessage() {
    alert("🚀 Welcome to your VIP DevOps Website!");
}

// Optional: Change background color on button click
function changeBackground() {
    const colors = ["#0f2027", "#203a43", "#2c5364", "#ff7e5f", "#feb47b"];
    const randomColor = colors[Math.floor(Math.random() * colors.length)];
    document.body.style.background = `linear-gradient(120deg, ${randomColor}, #203a43, #2c5364)`;
}

// Select the button and add event listener for background change
const btn = document.querySelector("button");
btn.addEventListener("click", () => {
    showMessage();       // alert
    changeBackground();  // change background color
});
