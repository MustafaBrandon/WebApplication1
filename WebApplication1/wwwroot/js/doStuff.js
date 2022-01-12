
$("#buttonSend").click(function () {
    //alert($("#intex").val())
    let grade = ((($("#assignments").val()) * 0.55) +
        (($("#group").val()) * 0.05) +
        ($("#quizzes").val() * 0.1) +
        ($("#exams").val() * 0.2) +
        ($("#intex").val() * 0.1))
    let message = ""
    if (grade < 60) { message = "E... too late for withdrawal?"}
    else if (grade < 64) { message = "D- ouch." }
    else if (grade < 67) { message = "D pretty bad." }
    else if (grade < 70) { message = "D+ not sure this gets degrees." }
    else if (grade < 74) { message = "C- this might get you a degree." }
    else if (grade < 77) { message = "C is this average?" }
    else if (grade < 80) { message = "C+ tough class huh." }
    else if (grade < 84) { message = "B- hey its a b!" }
    else if (grade < 87) { message = "B, great." }
    else if (grade < 90) { message = "B+ nice! Almost an A." }
    else if (grade < 94) { message = "A- Great work!" }
    else if (grade < 97) { message = "A sweeeet!" }
    else { message = "A+ perfect!" }
    let finalMessage = ("Your estimated final grade is: " + (grade) + " which is a " + message);
    alert(finalMessage);
})

