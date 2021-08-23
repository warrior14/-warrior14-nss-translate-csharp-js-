// Put your code here

console.log("My Enemies List!");
console.log("----------------");

// A function to make and return list of enemies:

const getEnemies = () => {
     // Make a list of Enemy objects:
    const enemies = [
        {
            firstName: "Joshua",
            lastName: "Flowers",
            offenses: [
                "Being a jerk to me in elementary school",
                "Not being nice to me in elementary school"
            ],
            isReallyHated: true
        },
        {
            firstName: "Darth",
            lastName: "Vader",
            offenses: [
                "Cut off Luke's hand",
                "Murdered all those kids",
                "Unkind management practices"
            ],
            isReallyHated: false
        },
        {
            firstName: "Betty",
            lastName: "Rudelady",
            offenses: [
                "Phone calls in the theater",
                "Phone calls on the bus",
                "Phone calls in line at the grocery store",
                "Poor conversationalist"
            ],
            isReallyHated: true
        },
        {
            firstName: "Leon",
            lastName: "Peck",
            offenses: [
                "Keeps giving me a hotplate"
            ],
            isReallyHated: false
        }
    ]

    return enemies;
};


const enemies = getEnemies();

for (const enemy of enemies) {
    if (enemy.isReallyHated) {
        console.log(`${enemy.firstName} ${enemy.lastName} (Really, really dislike!)`);
    } else {
        console.log(`${enemy.firstName} ${enemy.lastName}`);
    }
}