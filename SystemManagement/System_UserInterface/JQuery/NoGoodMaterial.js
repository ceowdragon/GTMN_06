$(document).ready(function () {
    var xMaterialsInOrder = new MaterialsInOrder();
})

class MaterialsInOrder {
    constructor() {
        this.LoadData();
        this.LoadEvents();
    }

    LoadEvents() {
        $('#update').click(this.ImportButtonOnClick.bind(this));
        //$('#submit').click(this.SubmitButtonOnClick.bind(this));
        $('#ad').click(this.AdButtonOnClick.bind(this));

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

        this.ShowDetailForm();
    }

    AdButtonOnClick() {
        var strHtml = $(`<div class="detail-treatment">
                        <input class="case" />
                        <input class="quanti" />
                    </div>`);
        $('.treatment').append(strHtml);
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