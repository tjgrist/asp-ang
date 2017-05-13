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
    public errorMsg;

    constructor(private postsService: PostsService) {}

    ngOnInit() {

    }

    publishPost(bodyVal) {
        let post = new Post(
            bodyVal,
            3,
            new Date()
        )
        
        this.postsService.createPost(post)
            .subscribe(data => this.response = data);
    }

}
