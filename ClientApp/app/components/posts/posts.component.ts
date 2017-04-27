import { PostsService } from '../../services/posts/posts.service';
import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'posts',
    templateUrl: 'posts.component.html',
    styleUrls: ['posts.component.css'],
    providers: [
        PostsService
    ]
})
export class PostsComponent implements OnInit{

    constructor(private postsService: PostsService) {
       
    }

    ngOnInit() {

    }

    publishPost() {
        var data = {

        }
        this.postsService.createPost(data);
    }

}
