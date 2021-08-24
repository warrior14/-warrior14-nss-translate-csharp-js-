// Put your code here 


console.log("Let's roll some dice baby!")
console.log("--------------------------")

// Function to "roll" a die:
//Generates a random number between 1 and 6:
const Roll = (min, max) => {
    min = Math.ceil(min);
    max = Math.floor(max);
    return Math.floor(Math.random() * (max - min + 1)) + min;
};

const convertDieIntToString = (dieValue) => {
    let dieString = "";


    switch (dieValue) {
        case 1:
            dieString = "one";
            break;
        case 2: 
            dieString = "two";
            break;
        case 3: 
            dieString = "three";
            break;
        case 4: 
            dieString = "four";
            break;
        case 5: 
            dieString = "five";
        case 6: 
            dieString = "six";
            break;
    }

    return dieString;


};


for (let i = 0; i < 10; i++) {
    let die1 = Roll(1, 6);
    let die2 = Roll(1, 6);


    let message = `${die1.toString()} + ${die2.toString()} == ${die1 + die2}`;
    if (die1 === die2) {
        message += "DOUBLES!";
    } else {
        console.log(message);
    }
}