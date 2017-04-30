import { Component, OnInit } from '@angular/core';
import { PostsService } from '../../services/posts/posts.service';

@Component({
    selector: 'new-post',
    templateUrl: 'new-post.component.html',
    styleUrls: ['new-post.component.css'],
    providers: [PostsService]
})
export class NewPostComponent implements OnInit{

    constructor(private postsService: PostsService) {}

    ngOnInit() {

    }

    publishPost() {
        var data = {}
        this.postsService.createPost(data);
    }

}
