"use strict";
var connection = new signalR.HubConnectionBuilder().withUrl("/NotificationHub").build();
 connection.on("sendToUser", (heading, content) => {
  
    //var heading = document.createElement("h3");
    //heading.textContent = articleHeading;
    //var p = document.createElement("p");
    //p.innerText = articleContent;

    //var div = document.createElement("div");
    //div.appendChild(heading);
    //div.appendChild(p);

    //document.getElementById("articleList").appendChild(div);

    var url = '../Home/Getnotifications';
    $.ajax({
        type: "POST",
        url: url,
        data: {
        },
        success: function (data) {
            console.log(data);
            $("#NotificationContainer").html(data); 
        }
    });
});
connection.start().catch(function (err) {
    return console.error(err.toString());
});