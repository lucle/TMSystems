// <binding AfterBuid='copy-modules' />
"use strict";

var gulp = require('gulp'),
    clean = require('gulp-clean'),
    glob = require('glob'),
    rimraf = require('rimraf'),
    concat = require('gulp-concat'),
    cssmin = require('gulp-cssmin'),
    uglify = require('gulp-uglify'),
    ignore = require('gulp-ignore'),
    del = require('del');

var paths = {
    webroot:"./wwwroot/",
    bower:".bower_components/"
};

var bower = {
    "bootstrap": "bootstrap/dist/**/*.{js,map,css,ttf,svg,woff,woff2,eot}",
    "font-awesome": "components-font-awesome/**/*.{css,tff,svg,woff,woff2,eot,otf}",
    "jquery": "jquery/dist/jquery*.{js,map}",
    "jquery-validation": "jquery-validation/dist/*.js",
    "jquery-validation-unobtrusive": "jquery-validation-unobtrusive/*.js"
};

gulp.task('clean-module', function () {
    return gulp.src([])
});

