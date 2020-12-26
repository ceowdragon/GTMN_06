$(document).ready(function () {
    var xMaterial = new MaterialJs();
})

class MaterialJs {
    constructor() {
        this.LoadData();
        this.LoadEvents();
        this.FormMode = null;
    }

    LoadEvents() {
        //Search
        $('.search').click(this.SearchButtonOnClick.bind(this));
        $('.search-tb').on("keypress", this.EnterButtonOnPress);

        //Button Click
        $('#add').click(this.AddButtonOnClick.bind(this));
        $('#save').click(this.SaveButtonOnClick.bind(this));
        $('#update').click(this.UpdateButtonOnClick.bind(this));
        $('#delete').click(this.DeleteButtonOnClick.bind(this));
        $('#import').click(this.ImportButtonOnClick.bind(this));
        $('#submit').click(this.SubmitButtonOnClick.bind(this));
        $('#cart').click(this.CartButtonOnClick.bind(this));
        $('#purchase').click(this.PurchaseButtonOnClick.bind(this));
        $('.close').click(this.CloseButtonOnClick.bind(this));

        //Table click
        $('.data-table tbody').on("click", "tr", this.CheckedRowSeleted);
        $('.data-table tbody').on("click", ".pick-up", this.CheckboxOnClick);
    }

    LoadData() {
        var self = this;
        var urlx = "";
        $('.data-table tbody').empty();

        if (self.FormMode == null) {
            urlx = "/Materials";
        }
        else {
            urlx = "/Materials/all";
            self.FormMode == null;
        }

        $.ajax({
            url: urlx,
            method: "GET",
            contentType: "application/json"
        }).done(function (res) {
            debugger;
            $.each(res, function (index, item) {
                var strHTML = $(`<tr>
                            <td>` + item.MaterialId + `</td>
                            <td>` + item.MaterialCode + `</td>
                            <td>` + item.MaterialName + `</td>
                            <td>` + item.MaterialDimensionX + `</td>
                            <td>` + item.MaterialDimensionY + `</td>
                            <td>` + item.MaterialFsc + `</td>
                            <td>` + item.MaterialUnit + `</td>
                            <td>` + item.MaterialFlute + `</td>
                            <td>` + item.MaterialStructure + `</td>
                            <td>` + item.MaterialPrize + `</td>
                            <td>
                                <input type="checkbox" class="pick-up" name="pickup" value="` + item.MaterialId + `">
                                <label for="materialid"></label>
                            </td>
                        </tr>`);
                $('.data-table tbody').prepend(strHTML);
            })
        }).fail(function (res) {
            alert("Tải dữ liệu thất bại!");
        })
    }

    ShowDetailForm() {
        $('.detail-form').show();
    }

    HideDetailForm() {
        $('.detail-form').hide();
    }

    ShowImportForm() {
        $('.import-form').show();
    }

    HideImportForm() {
        $('.import-form').hide();
    }

    ShowPurchaseForm() {
        $('.purchase-form').show();
    }

    HidePurchaseForm() {
        $('.purchase-form').hide();
    }

    CloseButtonOnClick() {
        if (this.FormMode == "import") {
            $('.import-form').hide();
            this.FormMode = null;
        }
        else {
            if (this.FormMode == "cart") {
                $('.purchase-form').hide();
                this.FormMode = null;
            }
            else
                $('.detail-form').hide();
        }
    }

    EnterButtonOnPress(event) {
        if (event.keyCode == 13) {
            $('.search').click();
        }
    }

    SearchButtonOnClick() {
        var key = $('.search-tb').val();

        debugger;
        if (key != "") {
            $.ajax({
                url: "/Materials/search/" + key,
                method: "GET",
                contentType: "application/json"
            }).done(function (res) {
                debugger;
                if (res.length > 0) {
                    $('.data-table tbody').empty();
                    $.each(res, function (index, item) {
                        var strHTML = $(`<tr>
                            <td>` + item.MaterialId + `</td>
                            <td>` + item.MaterialCode + `</td>
                            <td>` + item.MaterialName + `</td>
                            <td>` + item.MaterialDimensionX + `</td>
                            <td>` + item.MaterialDimensionY + `</td>
                            <td>` + item.MaterialFsc + `</td>
                            <td>` + item.MaterialUnit + `</td>
                            <td>` + item.MaterialFlute + `</td>
                            <td>` + item.MaterialStructure + `</td>
                            <td>` + item.MaterialPrize + `</td>
                        </tr>`);
                        $('.data-table tbody').append(strHTML);
                    })
                }
                else {
                    alert("Không tìm thấy mục nào với từ khóa <" + key + ">.");
                }
            }).fail(function (res) {
                alert("Có lỗi xảy ra!");
            })

            $('.search-tb').val("");
        }
        else {
            alert("Bạn phải nhập thông tin cần tìm kiếm!");
        }
    }

    AddButtonOnClick() {
        this.ShowDetailForm();
        this.FormMode = "add";

        $('#material-code').val("");
        $('#material-name').val("");
        $('#material-dimension-x').val("");
        $('#material-dimension-y').val("");
        $('#material-fsc').val("");
        $('#material-unit').val("");
        $('#material-flute').val("");
        $('#material-structure').val("");
        $('#material-prize').val("");
    }

    UpdateButtonOnClick() {
        var self = this;

        var selectedRow = $(".data-table tr.row-selected");
        if (selectedRow.length > 0) {
            var materialID = $(selectedRow).children()[0].textContent;

            $.ajax({
                url: "/Materials/" + materialID,
                method: "GET",
                contentType: "application/json"
            }).done(function (res) {
                if (res) {
                    $('#material-code').val(res["MaterialCode"]);
                    $('#material-name').val(res["MaterialName"]);
                    $('#material-dimension-x').val(res["MaterialDimensionX"]);
                    $('#material-dimension-y').val(res["MaterialDimensionY"]);
                    $('#material-fsc').val(res["MaterialFsc"]);
                    $('#material-unit').val(res["MaterialUnit"]);
                    $('#material-flute').val(res["MaterialFlute"]);
                    $('#material-structure').val(res["MaterialStructure"]);
                    $('#material-prize').val(res["MaterialPrize"]);
                    debugger;
                    self.ShowDetailForm();
                    self.FormMode = "update";
                }
            }).fail(function () {
                alert("Nguyên vật liệu " + materialCode + " không còn tồn tại trên hệ thống!")
            })
        }
        else {
            alert("Chưa có nguyên vật liệu nào được chọn!")
        }
    }

    DeleteButtonOnClick() {
        var self = this;

        var selectedRow = $(".data-table tr.row-selected");
        if (selectedRow.length > 0) {
            var materialCode = $(selectedRow).children()[1].textContent;

            $.ajax({
                url: "/Materials/" + materialCode,
                method: "DELETE"
            }).done(function (res) {
                debugger;
                self.FormMode = "delete";
                self.LoadData();
                alert("Xóa thành công " + res);
            }).fail(function (res) {
                alert(res + " đã bị xóa khỏi hệ thống!");
            })
        }
        else {
            alert("Chưa có nguyên vật liệu nào được chọn!")
        }
    }

    SaveButtonOnClick() {
        var self = this;
        var material = {
            MaterialCode: $('#material-code').val(),
            MaterialName: $('#material-name').val(),
            MaterialDimensionX: $('#material-dimension-x').val(),
            MaterialDimensionY: $('#material-dimension-y').val(),
            MaterialFsc: $('#material-fsc').val(),
            MaterialUnit: $('#material-unit').val(),
            MaterialFlute: $('#material-flute').val(),
            MaterialStructure: $('#material-structure').val(),
            MaterialPrize: $('#material-prize').val()
        }
        //Kiểm tra
        if ($('#material-code').val() != "" && $('#material-dimension-x').val() != "" && $('#material-dimension-y').val() != "") {

            var meth = "";
            if (self.FormMode == "add") {
                meth = "POST";
            }
            else meth = "PUT";
            //Gọi API service
            $.ajax({
                url: "/Materials",
                method: meth,
                data: JSON.stringify(material),
                contentType: "application/json",
                dataType: "json"
            }).done(function (res) {
                self.LoadData();
                self.HideDetailForm();
                alert("Đã nhập thành công " + res + " nguyên vật liệu!");
            }).fail(function (res) {
                alert("Đã xảy ra lỗi!");
                debugger;
            })
        }
        else {
            alert("Bạn phải nhập đầy đủ thông tin!");
        }
    }

    DisplayRowSelected() {
        //$(this).siblings().removeClass("row-selected");
        //$(this).addClass("row-selected");
    }

    ImportButtonOnClick() {
        var selectedRow = $(".data-table tr.row-selected");
        if (selectedRow.length > 0) {
            this.FormMode = "import";
            this.ShowImportForm();

            var materialCode = $(selectedRow).children()[1].textContent;
            var materialDimensionX = $(selectedRow).children()[3].textContent;
            var materialDimensionY = $(selectedRow).children()[4].textContent;
            var dimension = materialDimensionX + "x" + materialDimensionY;

            $('#mate-code').html(materialCode);
            $('#material-dimension').html(dimension);
        }
        else {
            alert("Chưa có nguyên vật liệu nào được chọn!")
        }
    }

    SubmitButtonOnClick() {
        var self = this;
        if ($('#material-quantity').val() != "" && $('#storage-code').val() != "") {
            var materialStorage = {
                MaterialstorageCode: $('#storage-code').val(),
                MaterialsinorderCode: $('#mate-code').html() + "BIMI",
                MaterialCode: $('#mate-code').html(),
                MaterialDimension: $('#material-dimension').html(),
                MaterialQuantity: $('#material-quantity').val(),
                MaterialstorageNote: $('#material-note').val()
            }
            debugger;
            $.ajax({
                url: "/MaterialStorages",
                method: "POST",
                data: JSON.stringify(materialStorage),
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

    CheckedRowSeleted() {
        
    }

    CheckboxOnClick() {
        var row = $(this).closest('tr');
        var rowCode = row.children()[1].textContent;
        var index = $.inArray(rowCode, listMaterialIdPickuped);

        // If checkbox is checked and row ID is not in list of selected row IDs
        if (this.checked && index === -1) {
            listMaterialIdPickuped.push(rowCode);
            row.addClass('row-pickuped');
            // Otherwise, if checkbox is not checked and row ID is in list of selected row IDs
        } else if (!this.checked && index !== -1) {
            listMaterialIdPickuped.splice(index, 1);
            row.removeClass('row-pickuped');
        }
    }

    CartButtonOnClick() {
        this.FormMode = "cart";
        
        $('#listCode').empty();

        if (listMaterialIdPickuped.length > 0) {
            this.ShowPurchaseForm();

            $.each(listMaterialIdPickuped, function (index, item) {
                var strhtml = `<li>` + item + `<input id="tb-` + item + `" type="text" /></li>`;
                $('#listCode').prepend(strhtml);
            });
        }
        else {
            alert("Chưa có mục nào được chọn!");
        }
    }

    PurchaseButtonOnClick() {
        var self = this;
        var count = 0;

        //Thêm vào danh sách mua hàng
        $('#listCode li input').each(function (index, item) {
            debugger;
            if (item.value != "") {
                count++;
            }
        })
        debugger;
        if (count == listMaterialIdPickuped.length) {
            $(listMaterialIdPickuped).each(function (index, item) {
                var materialsInorder = {
                    MaterialCode: item,
                    MaterialDimension: "300x400",
                    MaterialPrize: 2525,
                    MaterialQuantitySend: $('tb-' + item).val(),
                }
                debugger;

                $.ajax({
                    url: "/MaterialsInOrder",
                    method: "POST",
                    data: JSON.stringify(materialsInorder),
                    contentType: "application/json",
                    dataType: "json"
                }).done(function (res) {
                    debugger;
                }).fail(function (res) {
                    debugger;
                })
            })
        }
        else {
            alert("Bạn phải nhập đầy đủ thông tin!");
        }

        //Thêm vào ĐƠN MUA HÀNG
    }
}

var listMaterialIdPickuped = []
