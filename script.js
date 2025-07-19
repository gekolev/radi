const button = document.getElementById("testButton");

button.onclick = function () {
  console.log("Button was clicked!");

  // 1. If...else statement example

  const headings = document.querySelectorAll(".headings");

  const randomNumber = Math.random();
  if (randomNumber > 0.5) {
    console.log("if...else: Random number is greater than 0.5");
    headings.forEach(h => h.style.color = "red");
  } else {
    console.log("if...else: Random number is less than or equal to 0.5");
    headings.forEach(h => h.style.color = "blue");
  }

  console.log("Random number:", randomNumber); 

  // 2. Another if...else (checking textarea content)
  const textarea = document.querySelector("textarea");
  if (textarea.value.trim() === "") {
    console.log("if...else: Textarea is empty");
  } else {
    console.log("if...else: Textarea has some content");
  }

  // 3. For loop example
  for (let i = 1; i <= 3; i++) {
    console.log(`for loop: Iteration ${i}`);
  }
console
  // 4. Switch statement example
  const day = new Date().getDay(); // 0 = Sunday, 1 = Monday, ..., 6 = Saturday
  switch (day) {

    case 0:
      console.log("switch: It's Sunday!");
      break;

    case 1:
      console.log("switch: It's Monday!");
      break;

    case 2:
      console.log("switch: It's Tuesday!");
      break;

    case 3:
      console.log("switch: It's Wednesday!");
      break;

    case 4:
      console.log("switch: It's Thursday!");
      break;

    case 5:
      console.log("switch: It's Friday!"); 
      break;

    case 6:
      console.log("switch: It's Saturday!");
      break;

    default:
      console.log("switch: It's another day.");
      break;
  }
};

console.log("Script loaded successfully!");