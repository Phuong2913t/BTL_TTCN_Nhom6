
//function previewFile() {
//    var preview = documment.querySelector(".img");
//    var file = document.querySelector('input[type=file]').files[0];
//    var reader = new FileReader();

//    reader.onloadend = function () {
//        preview.src = reader.result;
//    }
//    if (file) {
//        reader.readAsDataURL(file);
//    } else {
//        preview.src = "";
//    }
//}

var previewFile = function (event) {
    var output = document.getElementById('output');
    output.src = URL.createObjectURL(event.target.files[0]);          //nếu dùng cái này thì cần thêm onchange vào input
    output.onload = function () {
        URL.revokeObjectURL(output.src) // free memory
    }
};