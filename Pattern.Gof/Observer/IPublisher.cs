﻿namespace Pattern.Gof.Observer;

public interface IPublisher
{
    void Subscribe(ISubscriber subscriber);

    void Unsubscribe(ISubscriber subscriber);

    void Notify();
}