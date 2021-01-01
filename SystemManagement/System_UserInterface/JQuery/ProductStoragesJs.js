$(document).ready(function () {
    var xProductStorages = new ProductStorages();
})

class ProductStorages {
    constructor() {
        this.LoadData();
        this.LoadEvents();
    }

    LoadEvents() {
        //$('#delivery').click(this.DeliveryButtonOnClick.bind(this));
        $('#confirm').click(this.ConfirmButtonOnClick.bind(this));

        $('.close').click(this.CloseButtonOnClick.bind(this));
        $('.data-table tbody').on("click", "tr", this.DisplayRowSelected);
    }

    LoadData() {
        $('.data-table tbody').empty();

        $.ajax({
            url: "/ProductStorages",
            method: "GET",
            contentType: "application/json"
        }).done(function (res) {
            $.each(res, function (index, item) {
                var strHtml = $(`<tr>
                            <td>` + item.ProductstorageId + `</td>
                            <td>` + item.ProductstorageCode + `</td>
                            <td>` + item.ProductCode + `</td>
                            <td>` + item.ProductDimension + `</td>
                            <td>` + item.ProductQuantity + `</td>
                            <td>` + item.ProductDelivery + `</td>
                            <td>` + item.ProductstorageNote + `</td>
                        </tr>`);
                $('.data-table tbody').append(strHtml);
            })
        }).fail(function (res) {
            debugger;
            alert("Có lỗi xảy ra!");
        })
    }

    ShowDeliveryForm() {
        $('.delivery-form').show();
        debugger;
    }

    HideDeliveryForm() {
        $('.delivery-form').hide();
    }

    CloseButtonOnClick() {
        this.HideDeliveryForm();
    }

    DeliveryButtonOnClick() {
        var selectedRow = $(".data-table tr.row-selected");
        if (selectedRow.length > 0) {
            this.ShowDeliveryForm();

            var id = $(selectedRow).children()[0].textContent;
            var code = $(selectedRow).children()[2].textContent;
            var dimension = $(selectedRow).children()[3].textContent;
            var storage = $(selectedRow).children()[1].textContent;
            var quantity = $(selectedRow).children()[4].textContent;

            $('#id1').html(id);
            $('.product-code').html(code);
            $('.product-dimension').html(dimension);
            $('#product-storage').html(storage);
            $('#product-quantity').html(quantity);
        }
        else {
            alert("Chưa có nguyên vật liệu nào được chọn!");
        }
    }

    ConfirmButtonOnClick() {
        var self = this;
        if ($('#delivery-quantity').val() != "") {
            var productStorage = {
                ProductstorageId: $('#id1').html(),
                ProductQuantity: $('#product-quantity').html() - $('#delivery-quantity').val(),
                ProductstorageNote: $('#delivery-note').val()
            }
            debugger;
            $.ajax({
                url: "/ProductStorages",
                method: "PUT",
                data: JSON.stringify(productStorage),
                contentType: "application/json",
                dataType: "json"
            }).done(function (res) {
                self.LoadData();
                self.HideDeliveryForm();
                alert("Đã xuất hàng thành công!");
            }).fail(function (res) {
                debugger;
                alert("Đã xảy ra lỗi!");
            })
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