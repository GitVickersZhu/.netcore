const uri = "api/package";
let todos = null;

$(document).ready(function () {

    initMap();
    getData();
});
var markers = [];
var markersDb = [];
var lng = [];
var lat = [];
var counter;
var infowindow;
var messagewindow;
var poly, geodesicPoly;
function initMap() {
    counter = 0;
    //document.getElementById('div-form').style.visibility = "hidden";
    var mapOptions = {
        center: new google.maps.LatLng(52.229675, 21.012230),
        zoom: 16,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };
    var map = new google.maps.Map(document.getElementById("map"),
        mapOptions);

    infowindow = new google.maps.InfoWindow({
        content: document.getElementById('div-form')
    });

    messagewindow = new google.maps.InfoWindow({
        content: document.getElementById('message')
    });


    google.maps.event.addListener(map, 'dblclick', function (event) {
        addMarker(event.latLng, map);

    });
};
function addMarker(location, map) {
    var marker = new google.maps.Marker({
        position: location,
        map: map
    });
    lat.push(location.lat());
    lng.push(location.lng());
    markers.push(marker);
    google.maps.event.addListener(marker, 'mouseover', function (event) {
        $("#div-form").css("visibility", "unset");
        infowindow.open(map, marker);
        $("#latdspl").html(event.latLng.lat().toFixed(4));
        $("#lngdspl").html(event.latLng.lng().toFixed(4));

    });
    google.maps.event.addListener(marker, "click", function () {
        getDistance(marker);
    });
}
function getDistance(marker) {
    alert(marker.getPosition());
    switch (markersDb.length) {
        case 0:
        case 1:
            markersDb.push(marker);
            break;
        case 2:
            var distance = google.maps.geometry.spherical.computeDistanceBetween(markersDb[0].getPosition(), markersDb[1].getPosition());
            $("#distance").html(distance);
            break;
        default:
            markersDb = [];
            alert("over flow");
    }

}
function getCount(data) {
    const el = $("#counter");
    let name = "item";
    if (data)
        el.text(data + " " + name);
    else el.text("0" + name);
}

function getData() {
    $.ajax({
        type: "GET",
        url: uri,
        cache: false,
        success: function (data) {
            const tBody = $("#packages");
            $(tBody).empty();
            //getCount(data);
            $.each(data, function (key, item) {
                const tr = $("<tr></tr>")
                    .append($("<td></td>").text(item.id))
                    .append($("<td></td>").text(item.name))
                    .append($("<td></td>").text(item.address))
                    .append($("<td></td>").text(item.size))
                    .append($("<td></td>").text(item.lng))
                    .append($("<td></td>").text(item.lat))
                    .append(
                        $("<td></td>").append(
                            $("<button>Delete</button>").on("click", function () {
                                deleteItem(item.id);
                            })
                        )
                    );
                tr.appendTo(tBody);
            });
            todos = data;
        }
    });
}

function addItem() {
    const item = {
        id: $("#lngdspl").text() * 10000,
        name: $("#name").val(),
        address: $("#address").val(),
        size: parseInt($("#size").val()),
        lng: $("#lngdspl").text(),
        lat: $("#latdspl").text()
    }
    $.ajax({
        type: "POST",
        accepts: "application/json",
        url: uri,
        contentType: "application/json",
        data: JSON.stringify(item),
        error: function (jqXHR, textStatus, errorThrown) {
            alert("Something went wrong!");
        },
        success: function (result) {
            getData();
        }
    });
}
function deleteItem(id) {

    $.ajax({
        url: uri + "/" + id,
        type: "DELETE",
        success: function (result) {
            getData();
        }
    });
}
