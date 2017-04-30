import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { UniversalModule } from 'angular2-universal';
import { AppComponent } from './components/app/app.component'
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { CounterComponent } from './components/counter/counter.component';
import { PostsService } from './services/posts/posts.service';
import { PostListComponent } from './components/post-list/post-list.component';
import { PostDetailComponent } from './components/post-detail/post-detail.component';
import { NewPostComponent } from './components/new-post/new-post.component';


@NgModule({
    bootstrap: [ AppComponent ],
    declarations: [
        AppComponent,
        NavMenuComponent,
        CounterComponent,
        NewPostComponent,   
        PostListComponent,
        PostDetailComponent,
        HomeComponent
    ],
    providers: [PostsService],
    imports: [
        UniversalModule, // Must be first import. This automatically imports BrowserModule, HttpModule, and JsonpModule too.
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'feed', component: PostListComponent },
            { path: 'feed/:id', component: PostDetailComponent },
            { path: 'new', component: NewPostComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ]
})
export class AppModule {
}
