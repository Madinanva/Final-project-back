function openNav() {
    document.getElementById("mySidenav").style.width = "250px";
  }
  
  function closeNav() {
    document.getElementById("mySidenav").style.width = "0";
  }

//Search
$(document).on("keyup", "#search-input", function () {
    let inputVal = $(this).val().trim();
    $("#search-results li").slice(0).remove();
    $.ajax({
        method: "get",
        url: "search/Search?search=" + inputVal,
        success: function (res) {
            $("#search-results").append(res);
        }
    })
})