import { Component, OnInit } from '@angular/core';
import { PostsService } from '../../services/posts/posts.service';

@Component({
    selector: 'posts',
    templateUrl: 'posts.component.html',
    styleUrls: ['posts.component.css'],
    providers: [PostsService]
})

export class PostsComponent implements OnInit {

    constructor (private _postsService: PostsService) {

    }

    ngOnInit() {
        //Called after the constructor, initializing input properties, and the first call to ngOnChanges.
        //Add 'implements OnInit' to the class.
        
    }

}
