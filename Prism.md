# Prism

## Prism的基本概念

* Modules。

模块是一些功能的集合，能够被单独地开发、测试和部署。在大多数情况下，模块是被不同的团队开发维护。一个典型的Prism程序是由多个模块组成的。模块用来表示特定业务相关的功能（例如配置文档管理），并且封装实现该功能需要的所有视图，服务，和数据模型。模块也可以用来封装程序中可以重用的通用程序代码或服务（例如登陆或异常管理服务）。
* Module catalog。

在复合程序中，模块(modules)必须由宿主程序(host application)动态地发现和加载。Prism中，模块目录是用来指定哪些模块需要被加载，加载时按照什么顺序加载。模块目录是有模块管理(module manager)组件和模块加载(module loader)组件使用。为了初始化模块，这两个组件需要下载模块（如果是远程模块的话），加载模块到程序的域中。Prism中可以使用多种方式指定模块目录，直接在代码中编写、使用XAML声明，或者是使用配置文件。如果有必要，你也可以实现一个自定义的模块目录。

* Shell。

Shell就是模块的宿主程序。Shell定义了总的布局以及程序结构，但是通常不知道具体寄宿在其中的是什么模块。它通常实现了公共程序服务和基本代码，但是大多数功能和内容则是在模块中实现的。Shell通常也提供了顶层的窗口或者虚拟元素用来承载模块提供的不同UI组件。

* Views。

View是封装了程序特定特性或功能的UI控件。View使用了MVVM模式来连接UI和后台逻辑代码及数据。View通常封装了UI界面并且定义了用户交互行为，使得View能够脱离功能地更新和替换。视图使用数据绑定来同Model层交互。

* View models。

View model是封装了程序界面逻辑和状态的类，属于MVVM模式。View model封装了大部分的程序功能。View model定义了属性、命令、事件，View通过数据绑定来访问这些属性、命令和事件。

* Models。

Model层的类封装程序的数据和业务逻辑，也是MVVM模式中的一部分。Model封装了数据以及任何与数据有关的认证或逻辑规则，以保证数据的完整性和一致性。

* Commands。

命令封装了程序的功能。使用命令能够让这些功能脱离UI界面地声明和测试。命令能够在View model层定义。Prism提供了DelegateCommand类和CompositeCommand类。CompositeCommand是用来表示一个能够相互调用的命令的集合。

* Region。

Region是一个逻辑占位，在Shell或者是View中定义。Region使得程序UI布局被更新而不需要去更改程序逻辑。许多通用控件可以被当成Region使用，比如ContentControl、ItemsControl、ListBox或者是TabControl。View能够在Region中自动显示或者是编程控制View显示。Prism能够让你通过Region实现导航。Region能够被其他的组件通过RegionManager组件指定位置。RegionManager使用RegionAdapter和RegionBehavior组件来整合显示在指定Region中的View。

* Navigation。

导航是一个改变程序UI来放映用户和程序交互的结果或者是程序内部状态变化的过程。Prism支持两种导航：一种是基于状态的导航，现有View的状态被更新来实现简单的导航；一种是View-Switching导航，新的View创建，来替换掉原来的View。View-Switching使用URI配合Region来实现灵活的导航。

* EventAggregator。

本来Event Aggregator（事件聚合器）或 Messenger 之类的组件本来并不是 MVVM 的一部分，不过现在也成了 MVVM 框架的一个重要元素。解耦是 MVVM 的一个重要目标，'EventAggregator' 则是实现解耦的重要工具。在 MVVM 中，对于 View 和与他匹配的 ViewModel 之间的交互，可以使用 INotifyProperty 和 Icommand；而对于必须通信的不同 ViewModel 或模块，为了使它们之间实现低耦合，可以使用 Prism 中的 EventAggregator。Publisher 和 Scbscriber 之间没有直接关联，它们通过 Event Aggregator 获取 PubSubEvent 并发送及接收消息。

* Dependency injection container。

Prism使用依赖注入模式管理组件之间的依赖。依赖注入使得组件之间的依赖能够动态的实现，并且是可扩展，可测试的。Prism支持的依赖注入有Unity和MEF，也可以使用其他的依赖注入容器通过ServiceLocator。

* Services。

Service封装UI无关的功能，例如登录、异常处理和数据获取。Service能直接在程序中定义或者是在模块中定义。Service通常由Dependency injection container注册，这样能够被其他依赖于Service的组件请求创建。

* Controllers。

Controller是用来定义结构和初始化将要显示在Region中的View的类。Controller封装了哪些Views将被显示的逻辑。Controller使用View-Switching的导航机制。

* Bootstrapper。

Bootstrapper组件是用来初始化Prism的组件和服务的。它用来初始化Dependency injection container来书册任何应用程序级的组件和服务。同时他还配置和初始模块目录以及Shell的View和View Model。

## 核心元素

* BindableBase and ErrorsContainer

BindableBase实现了INotifyPropertyChanged接口

```csharp
public class MockViewModel : BindableBase
{
    private string _myProperty;
    public string MyProperty
    {
        get { return _myProperty; }
        set { SetProperty(ref _myProperty, value); }
    }
}
```

* Commanding

DelegateCommand实现了ICommand接口

* Event Aggregator

* PrismApplication
* RegisterTypes
* XAML ContainerProvider
* ViewModelLocator
* DialogService，IDialogAware
