import { Component, OnInit } from '@angular/core'
import { PostsService } from '../../services/posts/posts.service'
import { Post } from '../../models/post'

@Component({
    selector: 'new-post',
    templateUrl: 'new-post.component.html',
    styleUrls: ['new-post.component.css'],
    providers: [PostsService]
})

export class NewPostComponent implements OnInit{
    public model;
    public response;

    constructor(private postsService: PostsService) {}

    ngOnInit() {

    }

    publishPost() {
        let post = new Post(
            this.model.body,
            5,
            new Date()
        )
        
        this.postsService.createPost(post)
            .subscribe(data => this.response = data);
    }

}
