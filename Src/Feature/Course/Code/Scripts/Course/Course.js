function nextToPage(page, ID, size) {
    var xhr = new XMLHttpRequest();
    xhr.open("POST", `api/course/CourseAPI/GetCourseByPage?page=${page}`);
    xhr.setRequestHeader("Content-Type", "application/json");
    xhr.onreadystatechange = () => {
        if (xhr.readyState == 4 && xhr.status == 200) {
            //Render html to view
            $("#data").html(JSON.parse(xhr.response).content);
            //Paging animation
            pagingAnimation(page);
            //Change url 
            var newurl = window.location.protocol + "//" + window.location.host + window.location.pathname + '?page=' + page;
            window.history.pushState({ path: newurl }, '', newurl);
        }
    };
    xhr.send(JSON.stringify({
        "ID": ID,
        "size": size
    }));
}
function pagingAnimation(page) {
    var list = document.getElementsByClassName("page-list");
    for (var i = 0; i < list.length; i++) {
        var item = list.item(i);
        item.classList.remove("active");
    }
    for (var i = 0; i < list.length; i++) {
        var item = list.item(i);
        if ((i + 1) == page) {
            item.classList.add("active");
        }
    }
}