$(document).ready(function () {
    var xProduct = new ProductsJs();
})

class ProductsJs {
    constructor() {
        this.LoadData();
        this.LoadEvents();
        this.FormMode = null;
    }

    LoadEvents() {
        //$('#add').click(this.AddButtonOnClick.bind(this));
        //$('#save').click(this.SaveButtonOnClick.bind(this));
        //$('#update').click(this.UpdateButtonOnClick.bind(this));
        //$('#delete').click(this.DeleteButtonOnClick.bind(this));

        //$('#import').click(this.ImportButtonOnClick.bind(this));
        $('#submit').click(this.SubmitButtonOnClick.bind(this));
        $('.close').click(this.CloseButtonOnClick.bind(this));
        $('.data-table tbody').on("click", "tr", this.DisplayRowSelected);
    }

    LoadData() {
        var self = this;
        $('.data-table tbody').empty();

        $.ajax({
            url: "/Products",
            method: "GET",
            contentType: "application/json"
        }).done(function (res) {
            debugger;
            $.each(res, function (index, item) {
                var strHTML = $(`<tr>
                            <td>` + item.ProductId + `</td>
                            <td>` + item.ProductCode + `</td>
                            <td>` + item.ProductName + `</td>
                            <td>` + item.ProductDimensionX + `</td>
                            <td>` + item.ProductDimensionY + `</td>
                            <td>` + item.ProductDimensionZ + `</td>
                            <td>` + item.ProductFsc + `</td>
                            <td>` + item.ProductUnit + `</td>
                            <td>` + item.ProductFlute + `</td>
                            <td>` + item.ProductShape + `</td>
                            <td>` + item.ProductPrize + `</td>
                        </tr>`);
                $('.data-table tbody').append(strHTML);
            })
        }).fail(function (res) {
            alert("Tải dữ liệu thất bại!");
        })
    }

    ShowDetailForm() {

    }

    HideDetailForm() {

    }

    ShowImportForm() {
        $('.import-form').show();
    }

    HideImportForm() {
        $('.import-form').hide();
    }

    CloseButtonOnClick() {
        this.HideDetailForm();
        this.HideImportForm();
    }

    AddButtonOnClick() {

    }

    UpdateButtonOnClick() {

    }

    DeleteButtonOnClick() {

    }

    SaveButtonOnClick() {

    }

    ImportButtonOnClick() {
        var selectedRow = $(".data-table tr.row-selected");
        if (selectedRow.length > 0) {
            this.ShowImportForm();

            var code = $(selectedRow).children()[1].textContent;
            var dimension = $(selectedRow).children()[3].textContent + "x" + $(selectedRow).children()[4].textContent;
            if ($(selectedRow).children()[5].textContent == 0) {
                dimension += "";
            }
            else {
                dimension += "x" + $(selectedRow).children()[5].textContent;
            }

            $('.product-code').html(code);
            $('.product-dimension').html(dimension);
        }
        else {
            alert("Chưa có nguyên vật liệu nào được chọn!")
        }
    }

    SubmitButtonOnClick() {
        var self = this;

        if ($('#product-quantity-tb').val() != "" && $('#product-storage-tb').val() != "") {
            var productStorage = {
                ProductstorageCode: $('#product-storage-tb').val(),
                ProductCode: $('.product-code').html(),
                ProductDimension: $('.product-dimension').html(),
                ProductQuantity: $('#product-quantity-tb').val(),
                ProductstorageNote: $('#product-note-tb').val()
            }
            debugger;
            $.ajax({
                url: "/ProductStorages",
                method: "POST",
                data: JSON.stringify(productStorage),
                contentType: "application/json",
                dataType: "json"
            }).done(function (res) {
                self.HideImportForm();
                self.FormMode = null;
                alert("Nhập thành công!");
            }).fail(function (res) {
                debugger;
                alert("Có lỗi xảy ra!");
            })

        }
        else {
            alert("Bạn phải nhập đầy đủ thông tin!");
        }
    }

    DisplayRowSelected() {
        $(this).siblings().removeClass("row-selected");
        $(this).addClass("row-selected");
    }
}