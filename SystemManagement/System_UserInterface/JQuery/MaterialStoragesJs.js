$(document).ready(function () {
    var xMaterialStorages = new MaterialStorages();
})

class MaterialStorages {
    constructor() {
        this.LoadData();
        this.LoadEvents();
    }

    LoadEvents() {
        $('#produce').click(this.ProduceButtonOnClick.bind(this));
        $('#confirm').click(this.ConfirmButtonOnClick.bind(this));

        $('.close').click(this.CloseButtonOnClick.bind(this));
        $('.data-table tbody').on("click", "tr", this.DisplayRowSelected);
    }

    LoadData() {
        $('.data-table tbody').empty();

        $.ajax({
            url: "/MaterialStorages",
            method: "GET",
            contentType: "application/json"
        }).done(function (res) {
            $.each(res, function (index, item) {
                var strHtml = $(`<tr>
                            <td>` + item.MaterialstorageId + `</td>
                            <td>` + item.MaterialstorageCode + `</td>
                            <td>` + item.MaterialsinorderCode + `</td>
                            <td>` + item.MaterialDimension + `</td>
                            <td>` + item.MaterialQuantity + `</td>
                            <td>` + item.MaterialDelivery + `</td>
                            <td>` + item.MaterialstorageNote + `</td>
                        </tr>`);
                $('.data-table tbody').append(strHtml);
            })
        }).fail(function (res) {
            debugger;
            alert("Có lỗi xảy ra!");
        })
    }

    ShowProduceForm() {
        $('.produce-form').show();
        debugger;
    }

    HideProduceForm() {
        $('.produce-form').hide();
    }

    CloseButtonOnClick() {
        this.HideProduceForm();
    }

    ProduceButtonOnClick() {
        var selectedRow = $(".data-table tr.row-selected");
        if (selectedRow.length > 0) {
            this.ShowProduceForm();

            var id = $(selectedRow).children()[0].textContent;
            var code = $(selectedRow).children()[2].textContent;
            var dimension = $(selectedRow).children()[3].textContent;
            var storage = $(selectedRow).children()[1].textContent;
            var quantity = $(selectedRow).children()[4].textContent;

            $('#id').html(id);
            $('#ms-code').html(code);
            $('#ms-dimension').html(dimension);
            $('#ms-storage').html(storage);
            $('#ms-quantity').html(quantity);
        }
        else {
            alert("Chưa có nguyên vật liệu nào được chọn!");
        }
    }

    ConfirmButtonOnClick() {
        var self = this;
        if ($('#produce-quantity').val() != "") {
            if ($('#ms-quantity').html() > $('#produce-quantity').val()) {
                
                var materialStorage = {
                    MaterialstorageId: $('#id').html(),
                    MaterialQuantity: $('#ms-quantity').html() - $('#produce-quantity').val(),
                    MaterialstorageNote: $('#produce-note').val()
                }
                debugger;
                $.ajax({
                    url: "/MaterialStorages",
                    method: "PUT",
                    data: JSON.stringify(materialStorage),
                    contentType: "application/json",
                    dataType: "json"
                }).done(function (res) {
                    self.LoadData();
                    self.HideProduceForm();
                    alert("Đã xuất hàng thành công!");
                }).fail(function (res) {
                    debugger;
                    alert("Đã xảy ra lỗi!");
                })
            }
            else {
                alert("Hàng tồn kho không đủ để xuất!");
            }
        }
        else {
            alert("Bạn phải nhập đủ thông tin!");
        }
    }

    DisplayRowSelected() {
        $(this).siblings().removeClass("row-selected");
        $(this).addClass("row-selected");
    }
}