
//Problem 1
let salaries = {
    John: 100,
    Ann: 160,
    Pete: 130
};

console.log(salaries);


function calculateSalaries(salaries){
    totalSalaries = 0;

    for (const property in salaries) {
        totalSalaries += salaries[property];
    }

    console.log(totalSalaries);
}

calculateSalaries(salaries);

//Problem 2
let menu = {
    width: 200,
    height: 300,
    title: "My menu"
};

console.log(menu);

function multiplyNumeric(menu){
    for (const property in menu) {
        if (typeof menu[property] == "number"){
            menu[property] *= 2;
        }
    }
}

multiplyNumeric(menu);

console.log(menu);

//Problem 3
//returns true if str contains '@' and ‘.’, otherwise false. Make sure
//'@' must come before '.' and there must be some characters between '@' and '.'
function checkEmailId(str){
    atIndex = str.indexOf("@");
    dotIndex = str.indexOf(".");
    if (dotIndex < (atIndex + 2)){
        return false;
    }
    if (atIndex < 0){
        return false;
    }
    return true;
}

//test cases
str1 = "@0.";
str2 = "@.";
str3 = ".@";
str4 = ".";
str5 = "@";
str6 = "";
console.log(checkEmailId(str1));
console.log(checkEmailId(str2));
console.log(checkEmailId(str3));
console.log(checkEmailId(str4));
console.log(checkEmailId(str5));
console.log(checkEmailId(str6));

//Problem 4
function truncate(str, maxlength) {
    if (str.length > maxlength){
        return result = str.substring(0, maxlength-1) + '...';
    }
    return str;
}

t1 = "What I'd like to tell on this topic is:";
t2 = "Hi everyone!";
console.log(truncate(t1, 20));
console.log(truncate(t2, 20));


//Problem 5
const arr = ["James", "Brennie"];
console.log(arr);
arr.push("Robert");
console.log(arr);
arr[Math.floor(arr.length/2)] = "Calvin";
console.log(arr);
arr.shift();
console.log(arr);
arr.unshift("Regal");
arr.unshift("Rose");
console.log(arr);


