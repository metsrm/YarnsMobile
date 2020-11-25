window.onload = function () {
	var nav = document.querySelector("div#navicon img");
	nav.onclick = function () {
		var list = document.querySelector("div#navicon + ul");
		list.style.display = "block";
	}zz

	var x = document.getElementById("icon");
	x.onclick = function () {
		var list = document.querySelector("div#navicon + ul");
		list.style.display = "none";
	}
}