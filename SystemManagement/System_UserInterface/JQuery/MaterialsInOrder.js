$(document).ready(function () {
    var xMaterialsInOrder = new MaterialsInOrder();
})

class MaterialsInOrder {
    constructor() {
        this.LoadData();
        this.LoadEvents();
    }

    LoadEvents() {
        $('#import').click(this.ImportButtonOnClick.bind(this));
        $('#submit').click(this.SubmitButtonOnClick.bind(this));

        $('.close').click(this.CloseButtonOnClick.bind(this));
        $('.data-table tbody').on("click", "tr", this.DisplayRowSelected);
    }

    LoadData() {
        $('.data-table tbody').empty();

        $.ajax({
            url: "/MaterialsInOrder",
            method: "GET",
            contentType: "application/json"
        }).done(function (res) {
            $.each(res, function (index, item) {
                var strHtml = $(`<tr>
                            <td>` + item.MaterialsinorderId + `</td>
                            <td>` + item.MaterialCode + `</td>
                            <td>` + item.MaterialDimension + `</td>
                            <td>` + item.MaterialPrize + `</td>
                            <td>` + item.MaterialQuantitySend + `</td>
                            <td>` + item.MaterialAmount + `</td>
                            <td>` + item.MaterialNote + `</td>
                        </tr>`);
                $('.data-table tbody').append(strHtml);
            })
        }).fail(function (res) {
            alert("Có lỗi xảy ra!");
        })
    }

    ShowDetailForm() {
        $('.detail-form').show();
    }

    HideDetailForm() {
        $('.detail-form').hide();
    }

    ShowImportForm() {
        $('.detail-form').show();
    }

    HideImportForm() {
        $('.detail-form').hide();
    }

    CloseButtonOnClick() {
        this.HideImportForm();
        this.HideDetailForm();
    }

    ImportButtonOnClick() {
        //var self = this;

        //var d = new Date();
        //var month = d.getMonth() + 1;
        //var day = d.getDate();
        //var output = (day < 10 ? '0' : '') + day + '/' + + (month < 10 ? '0' : '') + month + '/' + d.getFullYear();

        //var selectedRow = $('.data-table tr.row-selected');
        //if (selectedRow.length > 0) {
        //    this.ShowImportForm();
        //    var materialsinorderId = $(selectedRow).children()[0].textContent;

        //    $.ajax({
        //        url: "/MaterialsInOrder/" + materialsinorderId,
        //        method: "GET",
        //        contentType: "application/json"
        //    }).done(function (res) {
        //        $('#mio-code').html(res["MaterialCode"]);
        //        $('#mio-prize').html(res["MaterialPrize"]);
        //        $('#mio-dimension').html(res["MaterialDimension"]);
        //        $('#material-quantity-send').html(res["MaterialQuantitySend"]);
        //        $('#material-date').html(output);
        //        debugger;
        //    }).fail(function (res) {
        //        debugger;
        //    })
        //}
        //else {
        //    alert("Chưa có đơn hàng nào được chọn!");
        //}

        this.ShowImportForm();
    }

    SubmitButtonOnClick() {
        var self = this;

        if ($('#material-quantity-receive').val() != "" && $('#material-supplier').val() != "" && $('#sto-code').val() != "") {
            var materialStorage = {
                MaterialstorageCode: $('#sto-code').val(),
                MaterialsinorderCode: $('#mio-code').html() + $('#material-supplier').val(),
                MaterialCode: $('#mio-code').html(),
                MaterialDimension: $('#mio-dimension').html(),
                MaterialQuantity: $('#material-quantity-receive').val(),
                MaterialDelivery: $('#material-date').html(),
                MaterialstorageNote: $('#storage-note').val()
            }
            debugger;
            $.ajax({
                url: "/MaterialStorages",
                method: "POST",
                data: JSON.stringify(materialStorage),
                contentType: "application/json",
                dataType: "json"
            }).done(function (res) {
                debugger;
                self.LoadData();
                self.HideImportForm();
                alert("Đã nhập kho thành công!");
            }).fail(function (res) {
                debugger;
                alert("Có lỗi xảy ra!");
            })
        }
        else {
            alert("Bạn phải nhập đầy đủ thông tin!");
        }
    }

    UpdateButtonOnClick() {

    }

    DeleteButtonOnClick() {

    }

    SaveButtonOnClick() {

    }

    DisplayRowSelected() {
        $(this).siblings().removeClass("row-selected");
        $(this).addClass("row-selected");
    }


}