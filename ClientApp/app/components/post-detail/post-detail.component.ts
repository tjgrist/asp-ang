import { PostsService } from '../../services/posts/posts.service';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params }   from '@angular/router';
import { Location }                 from '@angular/common';
import { Post } from '../../models/post';

@Component({
  selector: 'app-post-detail',
  templateUrl: './post-detail.component.html',
  styleUrls: ['./post-detail.component.css'],
  providers: [PostsService]
})

export class PostDetailComponent implements OnInit {
  public post: Post;

  constructor(
    private route: ActivatedRoute,
    private location: Location,
    private _postsService: PostsService
  ) { }

  goBack(): void {
  this.location.back();
}

  ngOnInit() {
      this.route.params
    .switchMap((params: Params) => this._postsService.getPost(+params['id']))
    .subscribe(post => this.post = post);
  }

}