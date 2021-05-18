// 下拉列表js
(function($) {
    var $cate = $('.cate'),
        $tri = $('.cate_tri', $cate),
        $drop = $('div.cate_drop', $cate),
        $inp = $('div.cate_inp', $cate);

    $tri.on('click', function(event) {
        var $el = $(this);
        if( $el.data('active') !== 'on' ) {
            $drop[0].style.display = 'block';
            $el.data('active', 'on');
        } else {
            $drop[0].style.display = 'none';
            $el.data('active', 'off')
        }
    });

    $drop.on('mouseover', 'li', function(event) {
        $inp[0].innerHTML = this.innerHTML;
    }).on('click', 'li', function(event) {
        // do something
        $drop[0].style.display = 'none';
        $tri.data('active', 'off');
    });
}(jQuery));/**
 * Created by xiaoliang on 2015/4/7.
 */
