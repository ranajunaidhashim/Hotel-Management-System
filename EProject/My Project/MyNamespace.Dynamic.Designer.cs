using System;
using System.ComponentModel;
using System.Diagnostics;

namespace EProject.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Billing m_Billing;

            public Billing Billing
            {
                [DebuggerHidden]
                get
                {
                    m_Billing = Create__Instance__(m_Billing);
                    return m_Billing;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Billing))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Billing);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Currency m_Currency;

            public Currency Currency
            {
                [DebuggerHidden]
                get
                {
                    m_Currency = Create__Instance__(m_Currency);
                    return m_Currency;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Currency))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Currency);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Customers m_Customers;

            public Customers Customers
            {
                [DebuggerHidden]
                get
                {
                    m_Customers = Create__Instance__(m_Customers);
                    return m_Customers;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Customers))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Customers);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public item m_item;

            public item item
            {
                [DebuggerHidden]
                get
                {
                    m_item = Create__Instance__(m_item);
                    return m_item;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_item))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_item);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public LoginForm m_LoginForm;

            public LoginForm LoginForm
            {
                [DebuggerHidden]
                get
                {
                    m_LoginForm = Create__Instance__(m_LoginForm);
                    return m_LoginForm;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_LoginForm))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_LoginForm);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Mainform m_Mainform;

            public Mainform Mainform
            {
                [DebuggerHidden]
                get
                {
                    m_Mainform = Create__Instance__(m_Mainform);
                    return m_Mainform;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Mainform))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Mainform);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Restaurantinfo m_Restaurantinfo;

            public Restaurantinfo Restaurantinfo
            {
                [DebuggerHidden]
                get
                {
                    m_Restaurantinfo = Create__Instance__(m_Restaurantinfo);
                    return m_Restaurantinfo;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Restaurantinfo))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Restaurantinfo);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public test m_test;

            public test test
            {
                [DebuggerHidden]
                get
                {
                    m_test = Create__Instance__(m_test);
                    return m_test;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_test))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_test);
                }
            }

        }


    }
}