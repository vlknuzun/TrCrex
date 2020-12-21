import { NgModule } from '@angular/core';
import { ServerModule } from '@angular/platform-server';
import { ModuleMapLoaderModule } from '@nguniversal/module-map-ngfactory-loader';

import { AppComponent } from './app.component';
import { AppModule } from './app.module';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

const platform = platformBrowserDynamic();
platform.bootstrapModule(AppModule);

@NgModule({
    imports: [AppModule, ServerModule, ModuleMapLoaderModule],
    bootstrap: [AppComponent]
})
export class AppServerModule { }
