function more_information(i) {
    console.log(i);
    var desc = document.getElementById('description' + i);
    var btn = document.getElementById('namebtn');



    if (desc.style.display === 'block') {
        desc.style.display = 'none';
    }
    else {
        desc.style.display = 'block';
    }
}

function add_favourite(id) {
    $.ajax({
        url: `/favourite/${id}`,
    }).done(function () {
        var star = document.getElementById('star-' + id);

        if (star.className == "star-true") {
            star.className = "star-false";
        }
        else {
            star.className = "star-true";
        }
    })
}