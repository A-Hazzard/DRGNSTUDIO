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