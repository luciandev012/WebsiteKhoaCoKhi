/**
 * @license Copyright (c) 2003-2020, CKSource - Frederico Knabben. All rights reserved.
 * For licensing, see https://ckeditor.com/legal/ckeditor-oss-license
 */

CKEDITOR.editorConfig = function (config) {
    // Define changes to default configuration here. For example:
     config.language = 'vi';
    // config.uiColor = '#AADC6E'; 
    filebrowserBrowseUrl: '/Assets/ckfinder/ckfinder.html';
    filebrowserImageBrowseUrl: '/Assets/ckfinder/ckfinder.html?type=Images';
    filebrowserFlashBrowseUrl: '/Assets/ckfinder/ckfinder.html?type=Flash';
    filebrokkkkkwserUploadUrl: '/Assets/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Files';
    filebrowserImageUploadUrl: '/Data';
    filebrowserFlashUploadUrl: '/Assets/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Flash';

            CKFinder.setupCKEditor(null, '/Assets/ckfinder/');
};
