import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { PostsService } from '../../services/posts/posts.service';
import { Post } from '../../models/post';

@Component({
  selector: 'post-list',
  templateUrl: './post-list.component.html',
  styleUrls: ['./post-list.component.css']
})

export class PostListComponent implements OnInit {
    public posts: Post[];
    public selectedPost: Post;

  constructor(
    private _postsService: PostsService,
    private router: Router,
    ) { }

    ngOnInit() {
      this._postsService.getPosts()
         .subscribe(data => { this.posts = data as Post[]; }); 
    }

    viewDetail(post: Post){
      this.selectedPost = post;
      this.router.navigate(['/feed', post.id]);
    }

    private handleSuccess() {
        
    }
}

