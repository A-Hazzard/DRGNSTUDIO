function scrollright(){
    if ($(window).width() >= 1024) {
        console.log("correct");
        var right = document.querySelector("#image-wrapper");
        right.scrollBy(950, 0);
        // write you css here for screen size is more then 768
       }else if ($(window).width() > 768{
        console.log("wrong");
        var right = document.querySelector("#image-wrapper");
        right.scrollBy(800, 0);
       
       // write you css here for screen size is less then 768
       }
   

}

function scrollleft(){
var right = document.querySelector("#image-wrapper");
right.scrollBy(-1125, 0);

}