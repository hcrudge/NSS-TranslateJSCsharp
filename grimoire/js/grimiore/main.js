// Put your code here





const allSpells = [
    {
        Name: "Turn enemy into a newt",
        IsEvil: true,
        EnergyReqired: 5.1
    },
    {
        Name: "Conjure some gold for a local charity",
        IsEvil: false,
        EnergyReqired: 2.99
    },
    {
        Name: "Give a deaf person the ability to hear",
        IsEvil: false,
        EnergyReqired: 12.2
    },
    {
        Name: "Make yourself emperor of the universe",
        IsEvil: true,
        EnergyReqired: 100.0
    },
    {
        Name: "Convince your relatives your political views are correct",
        IsEvil: false,
        EnergyReqired: 2921.5
    }
]
console.log("Do you believe in magic?");
console.log("------------------------");

console.log("Good Book")
const goodSpells = allSpells.map((spell) => {
    if (spell.IsEvil === false) {
        console.log("   ",spell.Name)
        return spell.Name
    }
})
console.log("")
console.log("Evil Book")
const evilSpells = allSpells.map((spell) => {
    if (spell.IsEvil === true) {
        console.log("   ",spell.Name)
        return spell.Name
    }
})
