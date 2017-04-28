import { Injectable } from "@angular/core";
import { Http } from "@angular/http";

/**
 * @description
 * @class
 */
@Injectable()
export class PostsService {
  private allPostsRoute = 'api/posts/get';
  private postRoute = 'api/posts/post';

  constructor(private http: Http) {
    
  }

  getPosts() {
    return this.http
      .get(this.allPostsRoute)
      .map((response) => response.json());
  }

  createPost(data) {
    return this.http
      .post(this.postRoute, data)
      .map((response) => response.json());
  }

}
