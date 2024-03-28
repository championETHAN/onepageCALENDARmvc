//This is for crudLayer1-> Greeting Message
var greet = [
    'Good Morning',
    'Good Afternoon',
    'Good Evening'
][parseInt(new Date().getHours() / 24 * 3)];

document.getElementById("GreetingMessage").innerHTML = greet + " " + "Ethan";



//This is for crudLayer1 and crudLayer2-> Time and date displays
let dateLayer2 = document.getElementById("QuickDateLayer2");
let date = document.getElementById("QuickDate");
let time = document.getElementById("QuickTime");

setInterval(() => {
    let t = new Date();
    let f = new Date();
    let g = t;
    dateLayer2.innerHTML = g.toLocaleDateString();
    date.innerHTML = f.toLocaleDateString();
    time.innerHTML = t.toLocaleTimeString();
    
}, 1000)

//This is for crudLayer1 and crudLayer2-> navigation between layers
function Nav2Layer2( ) {
    var AddPage = document.getElementById("crudLayer2");
    AddPage.classList.toggle("show");


}
function Nav2Layer1() {
    var HomePage = document.getElementById("crudLayer2");
    HomePage.classList.toggle("show");
}