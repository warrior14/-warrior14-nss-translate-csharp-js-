// Put your code here

console.log("Do you believe in magic?");
console.log("------------------------");

// Function to make and return an array of spell objects:
const getAllSpells = () => {
    const spells = [
        {
            name: "Turn enemy into a newt",
            isEvil: true,
            energyRequired: 5.1
        },
        {
            name: "Conjure some gold for a local charity",
            isEvil: false,
            energyRequired: 2.99
        },
        {
            name: "Give a deaf person the ability to heal",
            isEvil: false,
            energyRequired: 12.2
        },
        {
            name: "Make yourself emperor of the universe",
            isEvil: true,
            energyRequired: 100.0
        },
        {
            name: "Convince your relatives your political views are correct",
            isEvil: false,
            energyRequired: 2921.5
        }
    ]

    return spells;
}

const allSpells = getAllSpells();

const makeGoodSpellBook = (allSpells) => {
    const goodSpellBook = {};
    goodSpellBook.title = "Good Book";
    goodSpellBook.spells = allSpells.filter(spell => spell.isEvil === false);

    return goodSpellBook;
}

const makeEvilSpellBook = (allSpells) => {
    const evilSpellBook = {};
    evilSpellBook.title = "Evil Book";
    evilSpellBook.spells = allSpells.filter(spell => spell.isEvil === true);

    return evilSpellBook;
}

const goodBook = makeGoodSpellBook(allSpells);
const evilBook = makeEvilSpellBook(allSpells);

const displaySpellBook = (book) => {
    console.log(book.title);
    for (const spell of book.spells) {
        console.log(`${spell.name}`);
    }
};

displaySpellBook(goodBook);
console.log("");
displaySpellBook(evilBook);