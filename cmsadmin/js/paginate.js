//the .children('a') below can be replaced with .children('tag or class name of the result items')
function paginateit(content) {
    var show_per_page = 5; //change this to the amount you want to see for each set
    var number_of_items = $(content).children('.salemainwrap').size();
    var number_of_pages = Math.ceil(number_of_items / show_per_page);
   
    if (number_of_items > show_per_page) {

        $(content).parent().find('.current_page').val(0);
        $(content).parent().find('.show_per_page').val(show_per_page);
        load_navigation(undefined, content);
        $(content).parent().find('.page_navigation .page_link:first').addClass('active_page');
        $(content).parent().find('.page_navigation .previous_link').addClass('previous_link disablelink');
        $(content).children('.salemainwrap').css('display', 'none');
        $(content).children('.salemainwrap').slice(0, show_per_page).css('display', 'block');
    }
}
function load_navigation(page_num, content) {

    var number_of_items = $(content).children('.salemainwrap').size();
    var show_per_page = $(content).parent().find('.show_per_page').val();
    var number_of_pages = Math.ceil(number_of_items / show_per_page);

    if (page_num == 0) {
        var navigation_html = '<a class="previous_link disablelink" href="javascript:previous(\'' + content + '\');">Prev</a>';
    }
    else {
        var navigation_html = '<a class="previous_link " href="javascript:previous(\'' + content + '\');">Prev</a>';
    }
    var max_pages_to_show = 3;
    if (number_of_pages > max_pages_to_show) {
        var middle_items = 2;
        var current_page = $(content).parent().find('.current_page').val();
        var start_range = parseInt(current_page) - Math.floor(middle_items);
        var end_range = parseInt(current_page) + Math.floor(middle_items);
        if (start_range < 0) {
            end_range += Math.abs(start_range);
            start_range = 0;
        }
        if (end_range > number_of_pages) {
            start_range -= end_range - number_of_pages;
            end_range = number_of_pages
        }
        var i = 0;
        while (i <= number_of_pages - 1) {
            if (start_range > 2 && i == start_range) {
                navigation_html += '...';
            }
            if (i == 1 || i == number_of_pages - 1 || (i >= start_range && i <= end_range)) {
                navigation_html += '<a class="page_link" href="javascript:go_to_page(' + i + ',\'' + content + '\')" longdesc="' + i + '">' + (i + 1) + '</a>';
            }
            if (end_range < number_of_pages - 1 && i == end_range) {
                navigation_html += '...';
            }
            i++;
        }
    } else {
        var current_link = 0;
        while (number_of_pages > current_link) {
            navigation_html += '<a class="page_link" href="javascript:go_to_page(' + current_link + ',\'' + content + '\')" longdesc="' + current_link + '">' + (current_link + 1) + '</a>';
            current_link++;
        }
    }
    // alert(number_of_pages);
    //if (number_of_pages == 3) {
    //navigation_html += '<a class="next_link disablelink" href="javascript:next_Page(\'' + content + '\');">Next</a>';
    //}
    if (page_num == number_of_pages - 1) {

        navigation_html += '<a class="next_link disablelink " href="javascript:next_Page(\'' + content + '\');">Next</a>';
    }
    else {
        navigation_html += '<a class="next_link" href="javascript:next_Page(\'' + content + '\');">Next</a>';
    }
    $(content).parent().find('.page_navigation').html(navigation_html);
    $('.page_link[longdesc=' + page_num + ']').addClass('active_page').siblings('.active_page').removeClass('active_page');
}

function previous(content) {
    new_page = parseInt($(content).parent().find('.current_page').val()) - 1;
    //if there is an item before the current active link run the function
    if ($(content).parent().find('.active_page').prev('.page_link').length == true) {
        go_to_page(new_page, content);
    }
}
function next_Page(content) {
    new_page = parseInt($(content).parent().find('.current_page').val()) + 1;
    //if there is an item after the current active link run the function

    if ($(content).parent().find('.active_page').next('.page_link').length == true) {
        go_to_page(new_page, content);
    }
}
function go_to_page(page_num, content) {
    $('html, body').animate({ scrollTop: $(content).offset().top - 140 }, 'slow');

    var show_per_page = parseInt($(content).parent().find('.show_per_page').val());
    start_from = page_num * show_per_page;
    end_on = start_from + show_per_page;
    $(content).children('.salemainwrap').css('display', 'none').slice(start_from, end_on).css('display', 'block');
    $(content).parent().find('.current_page').val(page_num);
    load_navigation(page_num, content);
}