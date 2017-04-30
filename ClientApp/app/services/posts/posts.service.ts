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
  private specificPostRoute = 'api/posts/getpost/';

  constructor(private http: Http) {
    
  }

  getPosts() {
    return this.http
      .get(this.allPostsRoute)
      .map((response) => response.json());
  }

  getPost(id: number) {
    return this.http
      .get(this.specificPostRoute + id)
      .map((response) => response.json());
  }

  createPost(data) {
    return this.http
      .post(this.postRoute, data)
      .map((response) => response.json());
  }



}
