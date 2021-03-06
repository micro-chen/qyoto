/****************************************************************************
**
** Copyright (C) 1992-2006 Trolltech ASA. All rights reserved.
**
** This file is part of the tools applications of the Qt Toolkit.
**
** Licensees holding valid Qt Preview licenses may use this file in
** accordance with the Qt Preview License Agreement provided with the
** Software.
**
** See http://www.trolltech.com/pricing.html or email sales@trolltech.com for
** information about Qt Commercial License Agreements.
**
** Contact info@trolltech.com if any conditions of this licensing are
** not clear to you.
**
** This file is provided AS IS with NO WARRANTY OF ANY KIND, INCLUDING THE
** WARRANTY OF DESIGN, MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE.
**
****************************************************************************/

#ifndef CSWRITEDECLARATION_H
#define CSWRITEDECLARATION_H

#include "treewalker.h"

class QTextStream;
class Driver;
class Uic;

struct Option;

namespace CS {

struct WriteDeclaration : public TreeWalker
{
    WriteDeclaration(Uic *uic);

    void acceptUI(DomUI *node);
    void acceptWidget(DomWidget *node);
    void acceptLayout(DomLayout *node);
    void acceptSpacer(DomSpacer *node);
    void acceptActionGroup(DomActionGroup *node);
    void acceptAction(DomAction *node);

private:
    Uic *uic;
    Driver *driver;
    QTextStream &output;
    const Option &option;
};

} // namespace CS

#endif // CSWRITEDECLARATION_H
