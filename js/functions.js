function scrollright(){
    let right = document.querySelector("#image-wrapper");
    if ($(window).width() >= 1024) {
        console.log("moved right on window 1024px");
        right.scrollBy(950, 0);
        
       }
       else if ($(window).width() >= 768){
        console.log("moved right on window 768px ");       
        right.scrollBy(589.3, 0);
  
       }
       if($(window).width() >= 1440){
           console.log("moved right on window 1440px");
           right.scrollBy(1136, 0);
       }
       if($(window).width() >= 1366){
        console.log("moved right on window 1366px");
        right.scrollBy(860, 0);
    }
   

}

function scrollleft(){
    let left = document.querySelector("#image-wrapper");
    if ($(window).width() >= 1024) {
        console.log("moved left on window 1024px");
        left.scrollBy(-950, 0);     
       }
       else if ($(window).width() >= 768){
        console.log("moved left on window 768px ");       
        left.scrollBy(-589.3, 0);
       }

       if($(window).width() >= 1440){
        console.log("moved left on window 1440px");
        left.scrollBy(-1136, 0);
    }
}


var currentMonth = document.querySelector(".current-month");
var calendarDays = document.querySelector(".calendar-days");
var today = new Date();
var date = new Date();
currentMonth.textContent = date.toLocaleDateString("en-US", {
	month: "long",
	year: "numeric"
});
today.setHours(0, 0, 0, 0);
renderCalendar();
function renderCalendar() {
	const prevLastDay = new Date(date.getFullYear(), date.getMonth(), 0).getDate();
	const totalMonthDay = new Date(
		date.getFullYear(),
		date.getMonth() + 1,
		0
	).getDate();
	const startWeekDay = new Date(date.getFullYear(), date.getMonth(), 1).getDay();
	calendarDays.innerHTML = "";
	let totalCalendarDay = 6 * 7;
	for (let i = 0; i < totalCalendarDay; i++) {
		let day = i - startWeekDay;
		if (i <= startWeekDay) {
			// adding previous month days
			calendarDays.innerHTML += `<div class='padding-day'>${
				prevLastDay - i
			}</div>`;
		} else if (i <= startWeekDay + totalMonthDay) {
			// adding this month days
			date.setDate(day);
			date.setHours(0, 0, 0, 0);
			let dayClass =
				date.getTime() === today.getTime() ? "current-day" : "month-day";
			calendarDays.innerHTML += `<div class='${dayClass}'>${day}</div>`;
		} else {
			// adding next month days
			calendarDays.innerHTML += `<div class='padding-day'>${
				day - totalMonthDay
			}</div>`;
		}
	}
}
document.querySelectorAll(".soft-btn").forEach(function (element) {
	element.addEventListener("click", function () {
		date = new Date(currentMonth.textContent);
		date.setMonth(
			date.getMonth() + (element.classList.contains("prev") ? -1 : 1)
		);
		currentMonth.textContent = date.toLocaleDateString("en-US", {
			month: "long",
			year: "numeric"
		});
		renderCalendar();
	});
});
document.querySelectorAll(".btn").forEach(function (element) {
	element.addEventListener("click", function () {
		let btnClass = element.classList;
		date = new Date(currentMonth.textContent);
		if (btnClass.contains("today")) date = new Date();
		else if (btnClass.contains("prev-year"))
			date = new Date(date.getFullYear() - 1, 0, 1);
		else date = new Date(date.getFullYear() + 1, 0, 1);
		currentMonth.textContent = date.toLocaleDateString("en-US", {
			month: "long",
			year: "numeric"
		});
		renderCalendar();
	});
});


